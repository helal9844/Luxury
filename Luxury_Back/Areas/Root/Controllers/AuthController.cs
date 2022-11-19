
using FluentValidation.Results;
using Luxury_Back.Areas.Root.Validations;
using Luxury_Back.DB;
using Luxury_Back.EmailServices;
using Luxury_Back.Models;
using Luxury_Back.Validations.Users;
using Luxury_Back.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;
using MimeKit;
using System;
using System.Drawing.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]

    public class AuthController : Controller
    {
        const string ViewPath = "Areas/Root/Views/Auth/";
        #region inject  Language, Database and MailingServices 
        //dependancy injection
        private readonly IStringLocalizer<AuthController> localizer;
        LuxuryDb luxuryDb;
       // private readonly IMailingService _mailingService;
        public AuthController(IStringLocalizer<AuthController> _localizer, LuxuryDb _luxuryDb)
        {
            localizer = _localizer;
            luxuryDb = _luxuryDb;
           // _mailingService = mailingService;
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

                    /*
                         user.is_active = true;

                        if (_user.is_active && !_user.is_admin)
                     */

                    if (!_user.is_admin)
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
                        TempData["error_msg"] = user.Email + " is not Allow To Login";
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
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region RandomNumber
        //1000 9999
        public int RandomNum(int min=1000,int max=9999)
        {
            var random = new Random();
            return random.Next(min,max);
        }
        #endregion

        #region Generate Random Code


        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var _random = new Random();
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):   
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        #endregion

        #region Admin SendMail Code To User
        // [HttpPost]
        //FromForm ==>maybe send attachments must[FromForm]
        //public async Task<IActionResult> SendEmail([FromForm] MailSendDto dto)
        //{
        //    await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, (IList<IFormFile>)dto.Attachments);
        //    return View();
        //}
        //public async Task<IActionResult> SendEmail(string ToEmail, string Subject, string Body)
        //{
        //    if (ToEmail != null && Subject != null && Body != null)
        //    {
        //        await _mailingService.SendEmailAsync(ToEmail, Subject, Body);
        //        TempData["check_email"] = "Please Check on Your Email and Enter Code Verfication in The Field";
        //        var user = luxuryDb.users.FirstOrDefault(x => x.Email == ToEmail);
        //        return View(user);
        //    }

        //    return RedirectToAction("Forget_Pass");
        //}



        //var message = new MimeMessage();
        //message.To.Add(new MailboxAddress("test", "user@server.com"));
        //message.From.Add(new MailboxAddress("do-not-reply", "do-not-reply@server.com"));
        //message.Subject = "TEST";

        //var mailkitClient = new SmtpClient();
        //client.Send("mhamd.tc.95@gmail.com", "mhmed.rady.95@gmail.com", "Hello world", "testbody");


        // await SendEmail("dalia.mahmoud.dm010@gmail.com", "Hello ", "ABCD");
        // return Content("send mail ");
        // }
        #endregion


        #region TestMail
        public bool testMail(string Email, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(Email);
                mail.From = new MailAddress("Luxury@asp.com");
                mail.Subject = "luxury mail";
                //  RandomString(4)
                mail.Body = $"<h1>Reset Code <u>{code}</u> </h1>";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("mhamd.tc.95@gmail.com", "fodjseviruvyedgt");
                smtp.Send(mail);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Forget Password GET
       
        [HttpGet]
        public IActionResult Forget_Pass()
        {
            return View();
        }
        #endregion

        #region Forget Password POST
       
        [HttpPost]
        public IActionResult Forget_Pass(string Email)
        {
           
            try
            {
                if (Email == null)
                {
                    TempData["error_msg"] = "Please Enter Your Email";
                   
                    return RedirectToAction("Forget_Pass");
                }
                var user = luxuryDb.users.Where(w => w.Email == Email).FirstOrDefault();
                if (user == null)
                {
                    TempData["error_msg"] = Email + " is not vaild";
                    //return View("/Forget_Pass.cshtml");
                    return RedirectToAction("Forget_Pass");
                }
                // var code = RandomString(4);
                var code = RandomNum().ToString();
                var codeRow = new Code_ForgetPass();
                // codeRow.Id = GetNextId(user.Id);
                codeRow.UserId = user.Id;
                codeRow.Code = code;

                luxuryDb.code_forget_passes.Add(codeRow);
                luxuryDb.SaveChanges();
                if (!testMail(user.Email, code))
                {
                    luxuryDb.code_forget_passes.Remove(codeRow);
                    luxuryDb.SaveChanges();
                    TempData["error_msg"] = "please enter your email again";
                    return View();
                }
                //  return RedirectToAction("Code_Verfication", new { id = user.Id });
                ViewBag.Id = user.Id;
                return View($"{ViewPath}Code_Verfication.cshtml");
                //commit
            }
            catch(Exception ex)
            {
                var user = luxuryDb.users.Where(w => w.Email == Email).FirstOrDefault();
                TempData["error_msg"] = "check your email";
                // return RedirectToAction("Code_Verfication", new { id = user.Id });
                ViewBag.Id = user.Id;
                return View($"{ViewPath}Code_Verfication.cshtml");
                //Rollback
            }

        }

        #endregion

        #region Code_Verfication Get
        public IActionResult Code_Verfication()
        {
            
            return View();
        }
        #endregion


        #region Verification Code post
        [HttpPost]
        public IActionResult Verify([FromForm] string code, int? Id)
        {
            try
            {
                if (code == null)
                {
                    TempData["error_msg"] = "Please Enter Code";

                    // return RedirectToAction("Code_Verfication", new { id = Id.Value });
                    ViewBag.Id = Id;
                    return View($"{ViewPath}Code_Verfication.cshtml");
                }

                //var user = luxuryDb.users.Include(i=>i.code).Where(w => w.Id == Id).FirstOrDefault();
                var user_code = luxuryDb.code_forget_passes.Include(i => i.user).Where(w => w.UserId == Id).FirstOrDefault();
                if (user_code.Code != code)
                {
                    TempData["error_code"] = "Please Enter Code Correct";
                    //return RedirectToAction("Code_Verfication", new { id = Id.Value });
                    ViewBag.Id = Id;
                    return View($"{ViewPath}Code_Verfication.cshtml");
                }
                ViewBag.Id = Id;
                // return RedirectToAction("New_Password", new { id = Id.Value });
                return View($"{ViewPath}New_Password.cshtml");
                // return View("/New_Password.cshtml");//passwrd and confirm password (New_Password.cshtml)
            }
            catch(Exception ex)
            {
                 // return Content(ex.ToString());
                 // TempData["empty"] = "sorry you attempt change someone else's password";
                // return RedirectToAction("Code_Verfication",new { id = Id });
                TempData["empty"] = "Please Enter Your Email To send Code to Reset Password";
                return RedirectToAction("Forget_Pass");
            }


        }

        #endregion


        #region New_Password get
        public IActionResult New_Password()
        {
            return View();
        }
        #endregion


        #region Reset Password post
        [HttpPost]
        public IActionResult Reset_Pass(Reset_Pass reset, int? Id)
        {
           
                UserResetPasswordValidation validator = new UserResetPasswordValidation(localizer);
                var results = validator.Validate(reset);
                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        TempData[failure.PropertyName] = failure.ErrorMessage;
                    }

                    // return RedirectToAction("New_Password", new { id = Id });
                    ViewBag.Id = Id;
                    return View($"{ViewPath}New_Password.cshtml");

                }
                var code_user = luxuryDb.code_forget_passes.FirstOrDefault(w => w.UserId == Id);
                if (code_user == null)
                {
                    TempData["error_msg"] = "user not found";
                    // return RedirectToAction("New_Password", new { id = Id });
                    ViewBag.Id = Id;
                    return View($"{ViewPath}New_Password.cshtml");
                }
                luxuryDb.code_forget_passes.Remove(code_user);
                luxuryDb.SaveChanges();
                var user = luxuryDb.users.FirstOrDefault(f => f.Id == Id);
                if (user == null)
                {
                    TempData["error_msg"] = "user not found";
                    // return RedirectToAction("New_Password", new { id = Id });
                    ViewBag.Id = Id;
                    return View($"{ViewPath}New_Password.cshtml");
                }
                user.password = reset.Password;
                user.confirm_password = reset.Confirm_Password;
                luxuryDb.users.Update(user);
                luxuryDb.SaveChanges();
                return RedirectToAction("Login");
            
           
           
        }

        #endregion


        #region Edit Profile get
        [HttpGet]
        public IActionResult Edit()
        {
            var userId = User.Claims.First(c => c.Type == "id").Value;
            var user = luxuryDb.users.FirstOrDefault(f => f.Id == int.Parse(userId));
            //ViewBag.user = User.Claims.First(c => c.Type == "name").Value;
            return View(user);
        }
        #endregion

        #region Edit Profile Post
        const string ViewPath_Home = "Areas/Root/Views/Auth/";
        [HttpPost]
        public IActionResult Edit(User user)
        {
            UserUpdateProfileValidation validator = new UserUpdateProfileValidation(localizer);

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
                bool isFound = luxuryDb.users.Where(w => !w.is_admin).Any(u => u.Id == user.Id);
                if (!isFound)
                {
                    TempData["error_msg"] = localizer["user_null"];
                    //  return RedirectToAction("Edit");
                    return View($"{ViewPath_Home}Edit.cshtml");
                }

                var exist = luxuryDb.users.Where(w => w.Id != user.Id).Where(h => h.Email == user.Email || h.username == user.username).Count();
                if (exist > 0)
                {
                    TempData["error_msg"] = localizer["user_null"];
                    // return RedirectToAction("Edit");
                    return View($"{ViewPath_Home}Edit.cshtml");
                }
                var pass = luxuryDb.users.Where(w => !w.is_admin && w.Id == user.Id).Select(s => s.password).First();
                user.password = pass.ToString();

                using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
                {
                    try
                    {
                        luxuryDb.users.Update(user);
                        luxuryDb.SaveChanges();
                        TempData["success_msg"] = user.username + localizer["update_success"];
                        transaction.Commit();
                        // return RedirectToAction("Edit");
                        return View($"{ViewPath_Home}Edit.cshtml");
                    }
                    catch (Exception ex)
                    {
                        TempData["error_msg"] = localizer["occur_error"];
                        transaction.Rollback();
                        // return RedirectToAction("Edit");
                        return View($"{ViewPath_Home}Edit.cshtml");
                    }
                }

            }

        }
        #endregion

        #region Edit password post
        const string ViewPath_Edit = "Areas/Root/Views/Auth/";

        [HttpPost]
        public IActionResult Edit_Pass(int Id, string password, string confirm_password)
        {
            if (password == null || confirm_password == null)
            {
                TempData["error_msg"] = localizer["pass_null"];
                //  return RedirectToAction("Edit");
                return View($"{ViewPath_Edit}Edit.cshtml");
            }
            if (password.Length < 8)
            {
                TempData["error_msg"] = localizer["pass_less_length"];
                // return RedirectToAction("Edit");
                return View($"{ViewPath_Edit}Edit.cshtml");
            }
            if (password != confirm_password)
            {
                TempData["error_msg"] = localizer["pass_not_match"];
                //return RedirectToAction("Edit");
                return View($"{ViewPath_Edit}Edit.cshtml");
            }
            var user = luxuryDb.users.FirstOrDefault(f => f.Id == Id);
            if (user == null)
            {

                TempData["error_msg"] = localizer["user_null"];
                //  return RedirectToAction("Edit");
                return View($"{ViewPath_Edit}Edit.cshtml");
            }
            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    luxuryDb.users.Update(user);
                    luxuryDb.SaveChanges();
                    TempData["success_msg"] = localizer["password"] + localizer["update_success"];
                    transaction.Commit();
                    // return RedirectToAction("Edit");
                    return View($"{ViewPath_Edit}Edit.cshtml");
                }
                catch (Exception ex)
                {
                    TempData["error_msg"] = localizer["occur_error"];
                    transaction.Rollback();
                    //  return RedirectToAction("Edit");
                    return View($"{ViewPath_Edit}Edit.cshtml");

                }
            }

        }
        #endregion

    }
}
