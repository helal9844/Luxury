using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
