using FluentValidation.Results;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Luxury_Back.Validations.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class AuthController : Controller
    {
        #region Language
        //dependancy injection
        private readonly IStringLocalizer<AuthController> localizer;
        LuxuryDb luxuryDb;
        public AuthController(IStringLocalizer<AuthController> _localizer, LuxuryDb _luxuryDb)
        {
            localizer = _localizer;
            luxuryDb = _luxuryDb;
        }

 
        #endregion

        #region Register get
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        #endregion

        #region Register Post

        [HttpPost]
        public IActionResult Register(User user)
        {
            UserRegisterValidation validator = new UserRegisterValidation(localizer);

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    TempData[failure.PropertyName] = failure.ErrorMessage;
                }
                return View(user);
            }
            else
            {
                var _user = luxuryDb.users.Where(u => u.username == user.username).FirstOrDefault();
                if (_user != null)//is  exist =>not register
                {
                    TempData["error_msg"] = _user.username + " is exist please enter new username";
                    return View(user);
                }
                var _user_email = luxuryDb.users.Where(u => u.Email == user.Email).FirstOrDefault();
                if (_user_email != null)//is  exist =>not register
                {
                    TempData["error_msg"] = _user_email.Email + " is exist please enter new Email";
                    return View(user);
                }
                user.is_active = true;
                luxuryDb.users.Add(user);
                luxuryDb.SaveChanges();
                return RedirectToAction("Login");

            }

        }
        #endregion

        #region Login get
        public IActionResult Login()
        {
            return View();
        }
        #endregion

        #region Login post
        [HttpPost]
        public IActionResult Login(User user)
        {
            UserLoginValidation validator = new UserLoginValidation(localizer);
            var results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    TempData[failure.PropertyName] = failure.ErrorMessage;
                }
                return View(user);
            }
            else
            {
                User _user = luxuryDb.users.Where(u => u.Email == user.Email)
                   .Where(u => u.password == user.password).FirstOrDefault();
                if (_user == null)
                {
                    TempData["error_msg"] = user.Email + " is not found";
                    return View();

                }
                else
                {
                    user.is_active = true;

                    if (user.is_active && !user.is_admin)
                    {
                        Claim u1 = new Claim("id", _user.Id.ToString());
                        Claim u2 = new Claim("name", _user.username);
                        Claim u3 = new Claim(ClaimTypes.Role, "user");
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity("userAuth");
                        claimsIdentity.AddClaim(u1);
                        claimsIdentity.AddClaim(u2);
                        claimsIdentity.AddClaim(u3);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        HttpContext.SignInAsync(claimsPrincipal);

                        return RedirectToAction("index","Home");
                    }
                    else
                    {
                        TempData["error_msg"] = user.Email + " is not Active";
                        return View();
                    }
                }
            }


        }
        #endregion

        #region LogOut
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        #endregion
    }
}
