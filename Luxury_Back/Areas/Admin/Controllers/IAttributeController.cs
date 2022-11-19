using FluentValidation;
using FluentValidation.Results;
using Luxury_Back.Areas.Admin.Validations;
using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;
using System.Data;

namespace Luxury_Back.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    [Area("admin")]
    public class IAttributeController : Controller
    {
        const string ViewPath = "Areas/Admin/Views/IAttribute/";
        LuxuryDb luxuryDb;
        private readonly IStringLocalizer<IAttributeController> localizer;

        public IAttributeController(LuxuryDb luxuryDb, IStringLocalizer<IAttributeController> _localizer, LuxuryDb db)
        {
            this.luxuryDb = db;
            this.localizer = _localizer;
        }

        public IActionResult Index(int? id)
        {
            // IEnumerable<IAttribute> attributes = luxuryDb.iAttributes.Take(5).ToList();
            var count = luxuryDb.iAttributes.Count();
            int pageSize = 5;
            int page_Num = count / pageSize;

            id = id == null ? 1 : id;
            TempData["prev"] = id > 1 ? id - 1 : null;
            TempData["next"] = id + 1;

            if (TempData["prev"] == null)//the first page
            {
                if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
                {
                    TempData["disabled_next"] = "disabled";
                }
                var first_page = luxuryDb.iAttributes.Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_prev"] = "disabled";
                TempData["id"] = id;
                return View(first_page);
            }

            if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
            {
                var last_page = luxuryDb.iAttributes.Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_next"] = "disabled";
                TempData["id"] = id;
                return View(last_page);
            }


            var move_page = luxuryDb.iAttributes.Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
            id = id + 1;
            TempData["id"] = id;
            return View(move_page);
            //  return View(attributes);
        }
        [HttpGet]
        public IActionResult Create(IAttribute iAttribute)
        {
            ViewBag.inputs = Types.iSelect.ToList();
            return View($"{ViewPath}Create_Edit.cshtml");
        }
        [HttpPost]
        public IActionResult _Create(IAttribute iAttribute)
        {
            IAttributeValidation validator = new IAttributeValidation(localizer);
            ValidationResult results = validator.Validate(iAttribute);
            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    TempData[error.PropertyName] = error.ErrorMessage;
                }
                return Create(iAttribute);
            }

            IAttribute? attribute = luxuryDb.iAttributes.Where(_ => _.name_ar == iAttribute.name_ar || _.name_en == iAttribute.name_en).FirstOrDefault();

            if (attribute != null)
            {
                TempData["error_msg"] = localizer["inserted before"];
                return RedirectToAction("Create", iAttribute);
            }

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.iAttributes.Add(iAttribute);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    TempData["success_msg"] = localizer["attribute"] + ' ' + localizer["add success"];
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            IAttribute? iAttribute = luxuryDb.iAttributes.Find(id);
            if (iAttribute == null)
                TempData["error_msg"] = localizer["attribute not exist"];

            ViewBag.inputs = Types.iSelect.ToList();
            return View($"{ViewPath}Create_Edit.cshtml", iAttribute);
        }

        [HttpPost]
        public IActionResult Edit(IAttribute iAttribute)
        {
            IAttributeValidation validator = new IAttributeValidation(localizer);
            ValidationResult results = validator.Validate(iAttribute);
            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    TempData[error.PropertyName] = error.ErrorMessage;
                }
                return Create(iAttribute);
            }

            /*var entity = luxuryDb.iAttributes.Find(iAttribute.Id);
            luxuryDb.Entry(entity).State = EntityState.Detached;*/

            bool isFound = luxuryDb.iAttributes.Any(att=>att.Id == iAttribute.Id);
            if (!isFound)
            {
                TempData["error_msg"] = localizer["attribute not exist"];
                return View($"{ViewPath}Create_Edit.cshtml", iAttribute);
            }

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.iAttributes.Update(iAttribute);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    TempData["success_msg"] = localizer["attribute"] + ' ' + localizer["updateSuccess"];
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                }
            }
            return View($"{ViewPath}Create_Edit.cshtml", iAttribute);
        }
        #region Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var iAttribute = luxuryDb.iAttributes.Find(id);
            if (iAttribute == null)
            {
                return NotFound(iAttribute.name_en + "is Not Found");
            }

            var iBookingAttributes = luxuryDb.iBookingAttributes.Where(w => w.IAttributeId == id).ToList();
            if (iBookingAttributes.Count > 0 && iBookingAttributes != null)
            {
                foreach (var item in iBookingAttributes)
                {
                    luxuryDb.iBookingAttributes.Remove(item);
                }
            }
            luxuryDb.iAttributes.Remove(iAttribute);
            luxuryDb.SaveChanges();

            TempData["Delete"] = Helper.getLnag() == "ar" ? iAttribute.name_ar + " " + "تم عملية المسح" : iAttribute.name_en + "Deleted Successfully";
            return RedirectToAction("Index");

        }

        #endregion


        #region Activation
        public IActionResult Activation(int? id)
        {
            var iAttribute = luxuryDb.iAttributes.Find(id);
            if (iAttribute == null)
            {
                TempData["error_msg"] = iAttribute.name_en + "is Not Found";
            }
            var iBookingAttributes = luxuryDb.iBookingAttributes.Where(w => w.IAttributeId == id).ToList();

            iAttribute.IsActive = !iAttribute.IsActive;
            luxuryDb.SaveChanges();

            return RedirectToAction("Index");
        }
        #endregion
    }
}
