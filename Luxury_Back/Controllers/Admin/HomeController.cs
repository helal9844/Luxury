using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Controllers.Admin
{
    public class HomeController : Controller
    {
        #region Language
        //dependancy injection
        private readonly IStringLocalizer<HomeController> localizer;
        public HomeController(IStringLocalizer<HomeController> _localizer)
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
