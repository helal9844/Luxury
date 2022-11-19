using FluentValidation.Results;
using Luxury_Back.Areas.Admin.Validations;
using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace Luxury_Back.Controllers.Admin
{

    [Authorize(Roles = "admin")]
    [Area("admin")]
    public class IBookingController : Controller
    {
        const string ViewPath = "Areas/Admin/Views/IBooking/";
        private LuxuryDb luxuryDb;
        private readonly IStringLocalizer<IBookingController> localizer;

        public IBookingController(LuxuryDb luxuryDb, IStringLocalizer<IBookingController> _localizer)
        {
            this.luxuryDb = luxuryDb;
            this.localizer = _localizer;
        }
        public IActionResult Index(int? id)
        {
            var booking_img = new List<IBookingImg>();


            // return bookings;
            // var bookings = luxuryDb.iBookings.Include(t => t.Category).Include(t => t.Brand).ToList();
            var count = luxuryDb.iBookings.Count();
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
                var first_page = luxuryDb.iBookings.Include(t => t.Category).Include(t => t.Brand).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_prev"] = "disabled";
                TempData["id"] = id;
                foreach (var booking in first_page)
                {
                    booking_img.Add(luxuryDb.iBookingImg.Where(w => w.IBookingId == booking.Id).FirstOrDefault());
                }
                ViewBag.IBookingImgs = booking_img;
                return View(first_page);
            }

            if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
            {
                var last_page = luxuryDb.iBookings.Include(t => t.Category).Include(t => t.Brand).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_next"] = "disabled";
                TempData["id"] = id;
                foreach (var booking in last_page)
                {
                    booking_img.Add(luxuryDb.iBookingImg.Where(w => w.IBookingId == booking.Id).FirstOrDefault());
                }
                ViewBag.IBookingImgs = booking_img;
                return View(last_page);
            }


            var move_page = luxuryDb.iBookings.Include(t => t.Category).Include(t => t.Brand).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
            id = id + 1;
            TempData["id"] = id;

            foreach (var booking in move_page)
            {
                booking_img.Add(luxuryDb.iBookingImg.Where(w => w.IBookingId == booking.Id).FirstOrDefault());
            }
            ViewBag.IBookingImgs = booking_img;
            return View(move_page);
            //  return View(bookings);
        }

        [HttpGet]
        public IActionResult Create(IBooking ibooking)
        {
            List<Category> categories = luxuryDb.categories.Include(ca => ca.childs).Where(c => c.CategoryId == null).ToList();
            List<Governorate> governorates = luxuryDb.governorates.ToList();
            List<IAttribute> iAttributes = luxuryDb.iAttributes.ToList();

            ViewBag.categories = categories;
            ViewBag.governorates = governorates;
            ViewBag.iAttributes = iAttributes;
            return View(ViewPath + "Create.cshtml");
        }

        [HttpPost]
        public IActionResult _Create(IBooking iBooking)
        {

            IBookingValidation validator = new IBookingValidation(localizer);
            ValidationResult results = validator.Validate(iBooking);
            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    TempData[error.PropertyName] = error.ErrorMessage;
                }
                return Create(iBooking);
            }

            IBooking? _ibooking = luxuryDb.iBookings
                        .Where(_ => _.name_ar == iBooking.name_ar || _.name_en == iBooking.name_en)
                        .FirstOrDefault();

            if (_ibooking != null)
            {
                TempData["error_msg"] = localizer["booking exist"];
                return Create(_ibooking);
            }

            // ADD IBOOKING ATTRIBUTES
            iBooking.iBookingAttributes = this.iBookingAttributes(Request);

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.iBookings.Add(iBooking);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    return RedirectToAction("Dropzone", new { id = iBooking.Id });
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                    return RedirectToAction("Create", iBooking);
                }
            }
        }

        public IActionResult Edit(int id)
        {
            IBooking iBooking = luxuryDb.iBookings.Include(i => i.Address).Include(i => i.iBookingAttributes).FirstOrDefault(i => i.Id == id);

            if (iBooking == null)
            {
                TempData["error_msg"] = "Data Not Found";
                return RedirectToAction("Index");
            }

            List<Category> categories = luxuryDb.categories.Include(ca => ca.childs).Where(c => c.CategoryId == null).ToList();
            List<Governorate> governorates = luxuryDb.governorates.ToList();
            List<IAttribute> iAttributes = luxuryDb.iAttributes.ToList();


            if (iBooking.Address != null)
            {
                var cities = luxuryDb.cities.Where(c => c.gov_id == iBooking.Address.GovernorateId).ToList();
                ViewBag.cities = cities;
            }

            if (iBooking.BrandId != null)
            {
                var brands = luxuryDb.brands.Where(c => c.CategoryId == iBooking.Category_Id).ToList();
                ViewBag.brands = brands;
            }

            ViewBag.categories = categories;
            ViewBag.iAttributes = iAttributes;
            ViewBag.governorates = governorates;


            return View(ViewPath + "Edit.cshtml", iBooking);
        }
        //[HttpPost]
        //public IActionResult _Edit(IBooking iBooking)
        //{
        //    bool isFound = luxuryDb.iBookings.Any(att => att.Id == iBooking.Id);
        //    if (!isFound)
        //    {
        //        TempData["error_msg"] = "Data Not Found";
        //        return RedirectToAction("Index");
        //    }

        //    // ADD IBOOKING ATTRIBUTES
        //    iBooking.iBookingAttributes = this.iBookingAttributes(Request);

        //    using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            luxuryDb.iBookings.Update(iBooking);
        //            luxuryDb.SaveChanges();
        //            transaction.Commit();
        //            TempData["success_msg"] = Helper.getLnag() == "ar" ? iBooking.name_ar : iBooking.name_en + localizer["updateSuccess"];
        //            return RedirectToAction("Index");
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            TempData["error_msg"] = ex.Message;
        //            return RedirectToAction("Edit", new { id = iBooking.Id });
        //        }
        //    }
        //}

        #region Edit Ibooking post 
        [HttpPost]
        public IActionResult _Edit(IBooking iBooking)
        {
            //  IBooking? _iBooking = luxuryDb.iBookings.FirstOrDefault(i=>i.Id == iBooking.Id);
            // IBooking? _iBooking = luxuryDb.iBookings.Where(w=>w.name_en== iBooking.name_en).FirstOrDefault();
            IBooking? _iBooking = luxuryDb.iBookings.Include(i => i.Address).Include(x => x.iBookingAttributes).FirstOrDefault(i => i.Id == iBooking.Id);

            if (_iBooking == null)
            {
                TempData["error_msg"] = "Data Not Found";
                return RedirectToAction("Index");
            }

            // ADD IBOOKING ATTRIBUTES
            _iBooking.iBookingAttributes = this.iBookingAttributes(Request);

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    _iBooking.name_ar = iBooking.name_ar;
                    _iBooking.name_en = iBooking.name_en;
                    _iBooking.description_ar = iBooking.description_ar;
                    _iBooking.description_en = iBooking.description_en;
                    _iBooking.updated_at = iBooking.updated_at;
                    //address
                    _iBooking.Address.IBookingId = iBooking.Id;
                    //_iBooking.Address.GovernorateId = iBooking.Address.GovernorateId;
                    //_iBooking.Address.CityId = iBooking.Address.CityId;
                    //_iBooking.Address.address = iBooking.Address.address;
                    _iBooking.Address = new Address()
                    {
                        address = iBooking.Address.address,
                        CityId = iBooking.Address.CityId,
                        GovernorateId = iBooking.Address.GovernorateId,
                        lat = iBooking.Address.lat,
                        lng = iBooking.Address.lng
                    };
                    //category
                    _iBooking.Category_Id = iBooking.Category_Id;
                    //brand
                    _iBooking.BrandId = iBooking.BrandId;
                    _iBooking.IsActive = iBooking.IsActive;


                    luxuryDb.iBookings.Update(_iBooking);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    TempData["success_msg"] = Helper.getLnag() == "ar" ? _iBooking.name_ar : _iBooking.name_en + localizer["updateSuccess"];
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                    return RedirectToAction("Edit", new { id = iBooking.Id });
                }
            }
        }
        #endregion

        [HttpGet]
        public IActionResult Dropzone(int? id)
        {
            ViewBag.id = id;
            return View($"{ViewPath}Dropzone.cshtml", id);
        }

        [HttpPost]
        public IActionResult _Dropzone(int? id)
        {
            var iBooking = luxuryDb.iBookings.Find(id);

            if (iBooking == null)
            {
                TempData["error_msg"] = localizer["not found"];
                return RedirectToAction("Index");
            }

            if (Request.Form.Files.Count() == 0)
            {
                TempData["error_msg"] = "Images Can't Be Empty";
                return RedirectToAction("Dropzone", new { id = id });
            }

            foreach (var file in Request.Form.Files)
            {
                IFormFile iformFile = file;
                iBooking.images.Add(new IBookingImg()
                {
                    Name = Helper.uploadeFile(iformFile, "iBooking")
                });
            }
            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.iBookings.Update(iBooking);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                    return Dropzone(iBooking.Id);
                }
            }

        }

        [HttpGet]
        public ActionResult Gallary(int? id)
        {
            IBooking? iBoking = luxuryDb.iBookings.Include(i => i.images).Where(i => i.Id == id).FirstOrDefault();

            if (iBoking == null)
            {
                TempData["error_msg"] = localizer["not found"];
                return RedirectToAction("Index");
            }

            return View($"{ViewPath}Gallary.cshtml", iBoking);
        }

        [HttpGet]
        public ActionResult removeImage(int? id, int? iBooking)
        {
            var ibooking = luxuryDb.iBookings.Include(i => i.images).Where(i => i.Id == iBooking).FirstOrDefault();
            if (ibooking != null)
            {
                var img = ibooking.images.FirstOrDefault(img => img.Id == id);
                if (img != null)
                {
                    luxuryDb.iBookingImg.Remove(img);
                    luxuryDb.SaveChanges();
                    return Json(true);
                }
            }
            return Json(false);
        }

        public ActionResult getBrandFromCategory(int? id)
        {
            List<Brand> brand = luxuryDb.brands.Where(b => b.CategoryId == id).ToList();

            return Json(Helper.jsonResult(brand));
        }

        public ActionResult getCitiesFromGov(int? id)
        {
            List<City> cities = luxuryDb.cities.Where(b => b.gov_id == id).ToList();
            return Json(Helper.jsonResult(cities));
        }

        public List<IBookingAttribute> iBookingAttributes(HttpRequest request)
        {
            List<IBookingAttribute> iBookingAttributes = new List<IBookingAttribute>();
            if (request.Form.Where(i => i.Key.StartsWith("attr_")).ToList() != null)
            {
                foreach (var item in request.Form.Where(i => i.Key.StartsWith("attr_")))
                {
                    if (item.Key.Contains("attr_"))
                    {
                        var id = int.Parse(item.Key.Split("_")[1]);
                        /*var attr = luxuryDb.iAttributes.Where(i => i.Id == id).FirstOrDefault();*/
                        string value = item.Value;
                        iBookingAttributes.Add(new IBookingAttribute()
                        {
                            IAttributeId = id,
                            value = value
                        });
                    }
                }
            }
            return iBookingAttributes;
        }

        #region Activation
        public IActionResult Activation(int? id)
        {
            var ibooking = luxuryDb.iBookings.Include(i => i.Category).Where(w => w.Id == id).FirstOrDefault();
            if (ibooking == null)
            {
                TempData["error_msg"] = "IBooking is Not Allow";
            }
            var num = ibooking.Category.childs.Count();
            if (num == 0)
            {

                ibooking.IsActive = ibooking.IsActive ? false : true;
                luxuryDb.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {
            var booking = luxuryDb.iBookings.Include(i => i.images).Where(w => w.Id == id).FirstOrDefault();
            if (booking == null)
            {
                TempData["error_msg"] = "Booking is Not Allow";
            }
            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    if (booking.images != null)
                    {
                        foreach (var bookImgs in booking.images)
                        {
                            luxuryDb.Remove(bookImgs);
                        }
                    }
                    /*if (booking.attribute != null)
                    {
                        luxuryDb.iBookingAttributes.Remove(booking.attribute);
                    }*/
                    luxuryDb.iBookings.Remove(booking);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    TempData["error_msg"] = "sorry can't remove This Booking";
                    transaction.Rollback();
                }
            }
            return RedirectToAction("Index");
        }

        #endregion


    }
}
