using FluentValidation;
using FluentValidation.Results;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Luxury_Back.Validations.admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Controllers.Admin
{
    public class IAttributeController : Controller
    {
        LuxuryDb luxuryDb;
        private readonly IStringLocalizer<IAttributeController> localizer;
        public IAttributeController(LuxuryDb luxuryDb, IStringLocalizer<IAttributeController> _localizer, LuxuryDb db)
        { 
            this.luxuryDb = db;
            this.localizer = _localizer;
        }
            const string ViewPath = "Views/Admin/IAttribute/";
        public IActionResult Index()
        {
            IEnumerable<IAttribute> attributes = luxuryDb.iAttributes.ToList();
            return View($"{ViewPath}Index.cshtml", attributes);
        }
        [HttpGet]
        public IActionResult Create(IAttribute iAttribute)
        {
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
                TempData["error_msg"] = "This Attribute Inserted Before.!";
                return RedirectToAction("Create", iAttribute);
            }

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.iAttributes.Add(iAttribute);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    TempData["success_msg"] = "Attribute Created Successfully!";
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
                TempData["error_msg"] = "This Attribute Is Not Exist.!";

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

            IAttribute _iAttribute = luxuryDb.iAttributes.Find(iAttribute.Id);
            if (_iAttribute == null)
            {
                TempData["error_msg"] = "This Attribute Is Not Exist.!";
                return View($"{ViewPath}Create_Edit.cshtml", iAttribute);
            }

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    /*_iAttribute.name_en = iAttribute.name_en;
                    _iAttribute.name_ar = iAttribute.name_ar;*/
                    luxuryDb.iAttributes.Update(_iAttribute);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    TempData["success_msg"] = "Attribute Data Updated Successfully!";
                    return RedirectToAction($"Index");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                }
            }
                return View($"{ViewPath}Create_Edit.cshtml", iAttribute);
        }
    }
}
