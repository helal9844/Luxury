using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/root");
        }
    }
}
