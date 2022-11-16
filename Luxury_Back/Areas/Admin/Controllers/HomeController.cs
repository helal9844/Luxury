using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Luxury_Back.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    [Area("admin")]
   

    public class HomeController : Controller
    {
        LuxuryDb db;

        #region Language
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

        const string ViewPath = "Views/Admin/Dashboard/";
        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
