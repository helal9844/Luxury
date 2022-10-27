using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Controllers.Admin
{
    public class AuthController : Controller
    {
        #region Language
        //dependancy injection
        private readonly IStringLocalizer<AuthController> localizer;
        public AuthController(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;
        }

        [HttpPost]
        public IActionResult SelectLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append
                (
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
            //return RedirectToAction(returnUrl);
        }
        #endregion
        const string ViewPath = "Views/Admin/Auth/";
        public IActionResult Login()
        {
            return View($"{ViewPath}Login.cshtml");
        }
    }
}
