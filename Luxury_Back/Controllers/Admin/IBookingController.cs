using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Controllers.Admin
{


    public class IBookingController : Controller
    {
        const string ViewPath = "Views/Admin/IBooking/";
        private LuxuryDb luxuryDb;
        private readonly IStringLocalizer<IBookingController> localizer;
        public IBookingController(LuxuryDb luxuryDb, IStringLocalizer<IBookingController> _localizer)
        {
            this.luxuryDb = luxuryDb;
            this.localizer = _localizer;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
