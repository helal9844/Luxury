using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Linq;

namespace Luxury_Back.Areas.Root.Controllers
{
    public record CategoryFilter(Category Category, bool IsSelected, int Count);
    //public class CategoryFilter2
    //{
    //    public CategoryFilter2(Category category, bool isSelected)
    //    {
    //        Category = category;
    //        IsSelected = isSelected;
    //    }
    //    public bool IsSelected { get; init; }
    //    public Category Category {get; init;}
    //}

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
            var topGovernorates = luxuryDb.governorates.Include(g => g.Addresses).Select(g => new { Id = g.Id, name = locale == "ar" ? g.name_ar : g.name_en, Count = g.Addresses.Count }).OrderByDescending(g => g.Count).Take(2);
            var topCategories = luxuryDb.categories.Where(c => c.CategoryId != null).Include(c => c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, Count = c.iBookings.Count, img = Helper.imageUrl(c.img_category) }).OrderByDescending(c => c.Count).Take(2);
            var topBrands = luxuryDb.brands.Include(c => c.iBookings).Select(c => new { Id = c.Id, name = locale == "ar" ? c.name_ar : c.name_en, Count = c.iBookings.Count, img = Helper.imageUrl(c.logo) }).OrderByDescending(c => c.Count).Take(2);
            var topCities = luxuryDb.cities.Include(g => g.Addresses).Select(g => new { Id = g.Id, name = locale == "ar" ? g.name_ar : g.name_en, Count = g.Addresses.Count }).Where(c=>c.Count>0).OrderByDescending(g => g.Count).Take(6);

            ViewBag.TopCategories = topCategories;
            ViewBag.TopBrands = topBrands;
            ViewBag.topGovernorates = topGovernorates;
            ViewBag.TopCities = topCities;
            ViewBag.locale = locale;
            return View();
        }

        public List<IBooking> Filter(string? cities, string? categories, string? brands, string? iAttributes)
        {
            var citiesIds = cities?.Split('_').Select(id => int.Parse(id));
            var categoriesIds = categories?.Split('_').Select(id => int.Parse(id));
            var brandsIds = brands?.Split('_').Select(id => int.Parse(id));
            var iAttributesIds = iAttributes?.Split('_').Select(id => int.Parse(id));

            var filter =
                luxuryDb.iBookings
                .Include(i => i.Category)//
                .Include(i => i.Brand)//
                .Include(i => i.Address)
                    .ThenInclude(a => a.City)
                .Include(i => i.Address)
                    .ThenInclude(a => a.Governorate)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)//
                .Where(i => i.Address.GovernorateId == 1)
                .Where(i => citiesIds == null || citiesIds.Contains(i.Address.CityId.Value))
                .Where(i => categoriesIds == null || categoriesIds.Contains(i.Category_Id.Value))
                .Where(i => brandsIds == null || brandsIds.Contains(i.BrandId.Value))
                .Where(i => iAttributesIds == null || iAttributesIds.All(aId => i.iBookingAttributes.Select(iBA => iBA.IAttributeId).Contains(aId)))
                .ToList();

            var categoriesToShow = luxuryDb.categories
                .Select(c => new CategoryFilter(c, categoriesIds.Contains(c.Id), filter.Count(b => b.Category_Id == c.Id)));//filter.Select(b => b.Category).Distinct().ToList();
            var brandsToShow = filter.Select(b => b.Brand).Distinct().ToList();
            var attributesToShow = luxuryDb.iAttributes.Select(att => new
            {
                Attribute = att,
                IsSelected = iAttributesIds.Contains(att.Id),
                Count = filter.Count(b => b.iBookingAttributes.Any(ia => ia.IAttributeId == att.Id))
            }); //filter.SelectMany(b => b.iBookingAttributes).Select(ia => ia.IAttribute).Distinct().ToList();

            return filter;
        }
    }
}
