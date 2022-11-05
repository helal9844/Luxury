using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers.Admin
{
    public class IBookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
