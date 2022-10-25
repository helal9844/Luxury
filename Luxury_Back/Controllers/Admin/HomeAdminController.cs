using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers.Admin
{
    public class HomeAdminController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Admin/HomeAdmin/idex.cshtml");
        }
    }
}
