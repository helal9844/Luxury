using Luxury_Back.Controllers;
using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;
using System.Data;
using System.Globalization;

namespace Luxury_Back.Areas.Root.Controllers
{
    [Area("Root")]
    public class IBookingController : LayoutController
    {
        #region Language

        public IBookingController(IStringLocalizer<IBookingController> _localizer, LuxuryDb luxury) : base(_localizer, luxury)
        {
            this.luxuryDb = luxury;
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
            return Content("IBooking");
        }
        public IActionResult Show(int? id)
        {
            var iBooking = luxuryDb.iBookings
                .Include(i => i.Address)
                    .ThenInclude(i => i.City)
                    .ThenInclude(i => i.Governorate)
                .Include(i => i.images)
                .Include(i => i.Brand)
                .Include(i => i.Category)
                .Include(i=> i.Checked_In)
                    .ThenInclude(i => i.User)
                .Include(i => i.iBookingAttributes)
                    .ThenInclude(i => i.IAttribute)
                .FirstOrDefault(i => i.Id == id);
            TopSearch();

            var recent = luxuryDb.iBookings
                .Include(i=>i.images.Take(1))
                .Include(i=>i.iBookingAttributes.Take(1))
                .Where(i => i.Category_Id == iBooking.Category_Id || i.BrandId == iBooking.BrandId)
                .Where(i=>i.Id != iBooking.Id)
                .Where(i=>i.images != null)
                .Distinct().OrderByDescending(i=>i.Id).Take(10).ToList();

            ViewBag.recentCount = recent.Count;
            ViewBag.recent = recent;

            return View(iBooking);
        }

        [HttpPost]
        public IActionResult CheckInForm([FromForm] int? iBookingId, [FromForm] string? checkInOut, [FromForm] string? person)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }

            if (iBookingId == null || checkInOut == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var _checkInOut = checkInOut.Split(" - ");
            var checkIn = DateTime.ParseExact(_checkInOut[0], "dd/MM/yyyy", null);
            var checkOut = DateTime.ParseExact(_checkInOut[1], "dd/MM/yyyy", null);

            var nights = int.Parse(checkOut.ToString("yyyMMdd")) - int.Parse(checkIn.ToString("yyyMMdd"));

            var userId = int.Parse(User.Claims.First(c => c.Type == "id").Value);

            if (iBookingId == null || userId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            IBooking? _IBooking = luxuryDb.iBookings.Include(i => i.iBookingAttributes.Take(1)).FirstOrDefault(i=>i.Id == iBookingId);
            User? user = luxuryDb.users.FirstOrDefault(i => i.Id == userId);
            if (_IBooking == null || user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            int amount = 0;

            if(_IBooking.iBookingAttributes.Count() !=0)
            {
                amount = int.Parse(_IBooking.iBookingAttributes.First().value) * nights;
            }

            Checked_In checked_In= new Checked_In()
            {
                IBookingId = _IBooking.Id,
                UserId = userId,
                nights_count = nights,
                checked_in = checkIn,
                checked_out = checkOut,
                IBooking = _IBooking,
                User = user,
                amount = amount
            };

            return View(checked_In);
       /*     return View();*/
        }

        [HttpPost]
        public IActionResult saveCheckIn(
                [FromForm] int? iBookingId, 
                [FromForm] DateTime? checked_in, 
                [FromForm] DateTime? checked_out,
                [FromForm] int? amount,
                [FromForm] int? UserId,
                [FromForm] int? nights_count
            )
        {

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }

            if (iBookingId == null || UserId ==null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    Checked_In checked_In = new Checked_In()
                    {
                        IBookingId = iBookingId.Value,
                        UserId = UserId.Value,
                        nights_count = nights_count.Value,
                        checked_in = checked_in.Value,
                        checked_out = checked_out.Value,
                        amount = amount.Value
                    };

                    luxuryDb.checked_in.Add(checked_In);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex){
                    transaction.Rollback();
                }
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
