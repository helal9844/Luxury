using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
