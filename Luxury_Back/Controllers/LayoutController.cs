using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Controllers
{
    public class LayoutController : Controller
    {

        private readonly IStringLocalizer<LayoutController> localizer;
        public LuxuryDb luxuryDb;
        public string locale = Helper.getLnag();
        public LayoutController(IStringLocalizer<LayoutController> _localizer, LuxuryDb luxury)
        {
            this.luxuryDb = luxuryDb;
            localizer = _localizer;        }

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

        public void TopSearch()
        {
            string locale = Helper.getLnag();
            var topGovernorates = luxuryDb.governorates.Include(g => g.Addresses).Select(g => new { Id = g.Id, image = g.img_governorate, name = locale == "ar" ? g.name_ar : g.name_en, Count = g.Addresses.Count }).OrderByDescending(g => g.Count).Take(10);
            var topCategories = luxuryDb.categories.Where(c => c.CategoryId != null).Include(c => c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, image = c.img_category, Count = c.iBookings.Count, img = Helper.imageUrl(c.img_category) }).OrderByDescending(c => c.Count).Take(2);
            var topBrands = luxuryDb.brands.Include(c => c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, Count = c.iBookings.Count, img = Helper.imageUrl(c.logo) }).OrderByDescending(c => c.Count).Take(2);
            var topCities = luxuryDb.cities.Include(g => g.Addresses).Select(g => new { Id = g.Id, name = locale == "ar" ? g.name_ar : g.name_en, Count = g.Addresses.Count }).Where(c => c.Count > 0).OrderByDescending(g => g.Count).Take(6);

            ViewBag.TopSearch = true;
            ViewBag.TopCategories = topCategories;
            ViewBag.TopBrands = topBrands;
            ViewBag.topGovernorates = topGovernorates;
            ViewBag.TopCities = topCities;
            ViewBag.locale = locale;
        }

    }
}
