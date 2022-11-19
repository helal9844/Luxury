using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Luxury_Back.Controllers.Admin
{

    [Area("admin")]


    public class HomeController : Controller
    {
        LuxuryDb db;

        #region Language
        //dependancy injection
        private readonly IStringLocalizer<HomeController> localizer;
        public HomeController(IStringLocalizer<HomeController> _localizer, LuxuryDb db)
        {
            localizer = _localizer;
            this.db = db;
        }

        [HttpPost]
        public IActionResult SelectLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append
                (
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
            //return RedirectToAction(returnUrl);
        }
        #endregion

        const string ViewPath = "Views/Admin/Dashboard/";
        [Authorize(Roles = "admin")]

        #region Index
        public IActionResult Index()
        {
            //cards
            TempData["count_checked"] = db.checked_in.Count();
            TempData["count_bookings"] = db.iBookings.Count();
            TempData["count_users"] = db.users.Count();
            TempData["mount_checked"] = db.checked_in.Sum(s => s.amount);

            //left table booking
            var list_bookings = db.iBookings.Include(i => i.Category).Include(n => n.Brand).OrderByDescending(o => o.Id).Take(5).ToList();

            //right table checked in
            ViewBag.list_check = db.checked_in.Include(i => i.IBooking).Include(n => n.User).OrderByDescending(o => o.Id).Take(5).ToList();

            return View(list_bookings);


        }
        #endregion

        #region Review Checked_In get
        public IActionResult Review(int id)//id checked in
        {
            var user_book = db.checked_in.Include(i => i.User).Include(n => n.IBooking).FirstOrDefault(f => f.Id == id);

            var bookAttr_check = db.iBookingAttributes.Where(e => e.IBookingId == user_book.IBookingId).Take(1).FirstOrDefault();
            TempData["bookAttr_check"] = bookAttr_check.value;
            //ViewBag.Bookings=  db.checked_in.Include(n => n.IBooking).Where(f => f.Id == id).ToList();
            //TempData["total_price"] = db.checked_in.Where(w=>w.UserId==id).Sum(s => s.amount);
            return View(user_book);
        }
        #endregion

    }
}