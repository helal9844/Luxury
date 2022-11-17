using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class IBookingController : Controller
    {
        #region Language
        LuxuryDb luxuryDb;
        //dependancy injection
        private readonly IStringLocalizer<IBookingController> localizer;
        public IBookingController(IStringLocalizer<IBookingController> _localizer, LuxuryDb db)
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
            return Content("IBooking");
        }

        public IBooking Show(int? id)
        {
            var iBooking = luxuryDb.iBookings
                .Include(i => i.Address)
                .Include(i => i.images)
                .Include(i => i.Brand)
                .Include(i => i.Category)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .FirstOrDefault(i => i.Id == id);
            return iBooking;
        }
    }
}
