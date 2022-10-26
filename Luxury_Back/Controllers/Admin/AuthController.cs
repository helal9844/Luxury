using Microsoft.AspNetCore.Mvc;

namespace Luxury_Back.Controllers.Admin
{
    public class AuthController : Controller
    {
        const string ViewPath = "Views/Admin/Auth/";
        public IActionResult Login()
        {
            return View($"{ViewPath}Login.cshtml");
        }
    }
}
