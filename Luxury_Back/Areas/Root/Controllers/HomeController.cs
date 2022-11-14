using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
   // [Authorize(Roles ="user")]
    public class HomeController : Controller
    {
        #region Language
        LuxuryDb luxuryDb;
        //dependancy injection
        private readonly IStringLocalizer<HomeController> localizer;
        public HomeController(IStringLocalizer<HomeController> _localizer, LuxuryDb db)
        {
            localizer = _localizer;
            this.luxuryDb = db;
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
        public IActionResult Index()
        {

            string locale = Helper.getLnag();
            var topGov = luxuryDb.governorates.Include(g=>g.Addresses).Select(g => new {Id  = g.Id, name = locale == "ar"? g.name_ar:g.name_en, Count = g.Addresses.Count }).OrderByDescending(g=> g.Count).Take(2);
            var topCat = luxuryDb.categories.Where(c=>c.CategoryId !=null).Include(c=>c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, Count = c.iBookings.Count, img = Helper.imageUrl(c.img_category) }).OrderByDescending(c=>c.Count).Take(2);
            var topBrands = luxuryDb.brands.Include(c => c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, Count = c.iBookings.Count, img = Helper.imageUrl(c.logo) }).OrderByDescending(c => c.Count).Take(2);
            
            return View();
        }
    }
}
