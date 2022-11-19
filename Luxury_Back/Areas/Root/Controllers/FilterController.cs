using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Areas.Root.Controllers
{
    public class FilterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
