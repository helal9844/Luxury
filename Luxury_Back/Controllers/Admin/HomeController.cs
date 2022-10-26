using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers.Admin
{
    public class HomeController : Controller
    {
        const string ViewPath = "Views/Admin/Dashboard/";
        public IActionResult Index()
        {
            return View($"{ViewPath}Index.cshtml");
        }

        public IActionResult About()
        {
            return View($"{ViewPath}About.cshtml");
        }
    }
}
