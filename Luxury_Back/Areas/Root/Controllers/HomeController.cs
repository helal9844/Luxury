using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
   // [Authorize(Roles ="user")]
    public class HomeController : Controller
    {
        #region Language
        LuxuryDb db;
        //dependancy injection
        private readonly IStringLocalizer<HomeController> localizer;
        public HomeController(IStringLocalizer<HomeController> _localizer, LuxuryDb db)
        {
            localizer = _localizer;
            this.db = db;
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
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
