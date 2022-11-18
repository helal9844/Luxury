using Luxury_Back.Controllers;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class IBookingController : LayoutController
    {
        #region Language

        public IBookingController(IStringLocalizer<IBookingController> _localizer, LuxuryDb luxury) : base(_localizer, luxury)
        {
            this.luxuryDb = luxury;
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
            return Content("IBooking");
        }
        public IActionResult Show(int? id)
        {
            var iBooking = luxuryDb.iBookings
                .Include(i => i.Address)
                    .ThenInclude(i =>i.City)
                    .ThenInclude(i => i.Governorate)
                .Include(i => i.images)
                .Include(i => i.Brand)
                .Include(i => i.Category)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .FirstOrDefault(i => i.Id == id);
            TopSearch();

            var recent = luxuryDb.iBookings
                .Include(i=>i.images.Take(1))
                .Include(i=>i.iBookingAttributes.Take(1))
                .Where(i => i.Category_Id == iBooking.Category_Id || i.BrandId == iBooking.BrandId)
                .Where(i=>i.Id != iBooking.Id)
                .Where(i=>i.images != null)
                .Distinct().OrderByDescending(i=>i.Id).Take(10).ToList();

            ViewBag.recentCount = recent.Count;
            ViewBag.recent = recent;

            return View(iBooking);
        }
    }
}
