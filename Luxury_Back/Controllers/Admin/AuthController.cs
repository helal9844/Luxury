using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers.Admin
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
