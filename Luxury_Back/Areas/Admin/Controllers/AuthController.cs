using FluentValidation.Results;
using Luxury_Back.Areas.Admin.Validations;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Security.Claims;

namespace Luxury_Back.Controllers.Admin
{
    [Area("admin")]
    public class AuthController : Controller
    {
        #region Language
        //dependancy injection
        private readonly IStringLocalizer<AuthController> localizer;
        LuxuryDb _luxuryDb;
        public AuthController(IStringLocalizer<AuthController> _localizer, LuxuryDb luxuryDb)
        {
            localizer = _localizer;
            _luxuryDb = luxuryDb;
        }
      
        #endregion

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            AdminLoginValidation validator = new AdminLoginValidation(localizer);

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    TempData[failure.PropertyName] = failure.ErrorMessage;
                }
            }
            else
            {
                User _user = _luxuryDb.users.Where(u => u.Email == user.Email)
                    .Where(u => u.password == user.password).FirstOrDefault();

                if (_user == null)
                {
                    TempData["userError"] = localizer["email"] + " " + localizer["Or"] + " " + localizer["placeholdpass"] + ' ' + localizer["correction"];
                }
                else
                {
                    if (_user.is_active && _user.is_admin)
                    {
                        // login 
                        Claim a1 = new Claim("id", _user.Id.ToString());
                        Claim a2 = new Claim("name", _user.username);
                        Claim a3 = new Claim(ClaimTypes.Role, "admin");
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity("userAuth");
                        claimsIdentity.AddClaim(a1);
                        claimsIdentity.AddClaim(a2);
                        claimsIdentity.AddClaim(a3);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        HttpContext.SignInAsync(claimsPrincipal);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["userError"] = localizer["user not valid"];
                    }
                }
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
