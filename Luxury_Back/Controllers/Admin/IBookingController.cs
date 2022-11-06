using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Luxury_Back.Controllers.Admin
{


    public class IBookingController : Controller
    {
        const string ViewPath = "Views/Admin/IBooking/";
        private LuxuryDb luxuryDb;
        private readonly IStringLocalizer<IBookingController> localizer;
        public IBookingController(LuxuryDb luxuryDb, IStringLocalizer<IBookingController> _localizer)
        {
            this.luxuryDb = luxuryDb;
            this.localizer = _localizer;
        }
        public IActionResult Index()
        {
             var booking_img =new List<IBookingImg>();
            
           
            // return bookings;
            var bookings = luxuryDb.iBookings.Include(t => t.Category).Include(t => t.Brand).ToList();
            
            foreach (var booking in bookings)
            {
                booking_img.Add(luxuryDb.iBookingImg.Where(w => w.IBookingId == booking.Id).FirstOrDefault());
            }
            ViewBag.IBookingImgs=booking_img;
            return View($"{ViewPath}Index.cshtml", bookings);
        }

        #region Activation
        public IActionResult Activation(int? id)
        {
          var ibooking=  luxuryDb.iBookings.Include(i=>i.Category).Where(w => w.Id == id).FirstOrDefault();
            if (ibooking == null)
            {
                TempData["error_msg"] = "IBooking is Not Allow";
            }
           var num= ibooking.Category.childs.Count();
            if (num == 0)
            {
               
                ibooking.IsActive = ibooking.IsActive ? false : true;
                luxuryDb.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        #endregion


    }
}
