using Luxury_Back.Controllers;
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
    public class HomeController : LayoutController
    {

        public HomeController(IStringLocalizer<HomeController> _localizer, LuxuryDb luxury): base(_localizer, luxury)
        {
            this.luxuryDb = luxury;
        }
        public IActionResult Index()
        {
            this.TopSearch();

            var recent = luxuryDb.iBookings
                .Include(i => i.images.Take(1))
                .Include(i => i.iBookingAttributes.Take(1))
                
                .Where(i => i.images != null)
                .Distinct().Take(10).ToList();

            ViewBag.recentCount = recent.Count;
            ViewBag.recent = recent;

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
