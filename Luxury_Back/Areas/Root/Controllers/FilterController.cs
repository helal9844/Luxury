using Luxury_Back.Controllers;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class FilterController : LayoutController
    {
        public FilterController(IStringLocalizer<LayoutController> _localizer, LuxuryDb luxury) : base(_localizer, luxury)
        {
            this.luxuryDb = luxury;
        }

        /*public IActionResult Index(string? cities, string? categories, string? brands, string? iAttributes)
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

            return View();
        }*/

        public IActionResult Filter(string? cities, int? categories, string? brands, string? iAttributes)
        {
            
            var ibookings = luxuryDb.iBookings
                .Include(i => i.Category)//
                .Include(i => i.Brand)//
                .Include(i=>i.images.Take(1))
                .Include(i => i.Address)
                    .ThenInclude(a => a.City)
                .Include(i => i.Address)
                    .ThenInclude(a => a.Governorate)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .Where(i=>i.Category_Id == categories)//
            .ToList();

            return View(ibookings);
        }

        public IActionResult FiterCity(int? cityId, int? room)
        {

            var ibookings = luxuryDb.iBookings
                .Include(i => i.Category)//
                .Include(i => i.Brand)//
                .Include(i => i.images.Take(1))
                .Include(i => i.Address)
                    .ThenInclude(a => a.City)
                .Include(i => i.Address)
                    .ThenInclude(a => a.Governorate)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .Where(i => i.Address.CityId == cityId)
                //
            .ToList();
        
            return View("Areas/Root/Views/Filter/Filter.cshtml", ibookings);
        }

        public IActionResult FiterGov(int? govId)
        {

            var ibookings = luxuryDb.iBookings
                .Include(i => i.Category)//
                .Include(i => i.Brand)//
                .Include(i => i.images.Take(1))
                .Include(i => i.Address)
                    .ThenInclude(a => a.City)
                .Include(i => i.Address)
                    .ThenInclude(a => a.Governorate)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .Where(i => i.Address.GovernorateId == govId)
            //
            .ToList();

            return View("Areas/Root/Views/Filter/Filter.cshtml", ibookings);
        }

    }
}
