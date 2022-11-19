using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Drawing.Printing;
using System.Linq;

namespace Luxury_Back.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CheckedController : Controller
    {
        #region Language
        LuxuryDb luxuryDb;
        //dependancy injection
        private readonly IStringLocalizer<CheckedController> localizer;
        public CheckedController(IStringLocalizer<CheckedController> _localizer, LuxuryDb db)
        {
            localizer = _localizer;
            this.luxuryDb = db;
        }
        #endregion
        //public IActionResult Checked()
        //{
        //   var list_checked= luxuryDb.checked_in.Include(i=>i.User).Include(n=>n.IBooking).Take(1).ToList();
        //    return View(list_checked);
        //}

        #region Index

        const string ViewPath = "Areas/Admin/Views/Checked/";
        public IActionResult Index(int? id)
        {
            var count = luxuryDb.checked_in.Count();
            int pageSize = 5;
            int page_Num = count / pageSize;

            id = id == null ? 1 : id;
            TempData["prev"] = id > 1 ? id - 1 : null;
            TempData["next"] = id + 1;

            if (TempData["prev"] == null)//the first page
            {
                if (count == 0)//i make this condition because of not divided on zero in line number 49
                {
                    
                    return View();
                }
                if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
                {
                    TempData["disabled_next"] = "disabled";
                   
                }
                var first_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).ThenInclude(i => i.iBookingAttributes.Take(1)).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                if (first_page == null)
                {
                   
                    return View();
                }
                TempData["disabled_prev"] = "disabled";
                TempData["id"] = id;
                return View(first_page);
            }

            if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
            {
                var last_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).ThenInclude(i => i.iBookingAttributes.Take(1)).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                if (last_page == null)
                {

                    return View();
                }
                TempData["disabled_next"] = "disabled";
                TempData["id"] = id;
                return View(last_page);
            }
            //var bookAttr_check = luxuryDb.iBookingAttributes.Where(i => i.IBookingId == checked_IBookingId).Take(1).FirstOrDefault();
            //TempData["value_bookAttr_check"] = bookAttr_check.value;

            var move_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).ThenInclude(i => i.iBookingAttributes.Take(1)).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
            if (move_page == null)
            {
                return View();
            }
            id = id + 1;
            TempData["id"] = id;
            return View(move_page);



        }
        #endregion

        #region all of Data_User with booking Data_User

        [HttpPost]
        public IActionResult Data_User(int? id ,int UserId,int checked_IBookingId)//pagination num,userid,checked_id
        {
            #region user data
            //user data
            var user = luxuryDb.users.FirstOrDefault(f => f.Id == UserId);
            if (user == null)
            {
                TempData["error_msg"] = "user is not found";
                return View($"{ViewPath}Index.cshtml");
            }
            ViewBag.username = user.username;
            ViewBag.email = user.Email;
            ViewBag.phone = user.Phone;

            //
            #endregion


            var bookAttr_check = luxuryDb.iBookingAttributes.Where(i => i.IBookingId == checked_IBookingId).Take(1).FirstOrDefault();
            TempData["value_bookAttr_check"] =bookAttr_check.value;
            //ViewBag.amount = user.amount;
            //luxuryDb.iBookingAttributes.
            // pagination
            var count = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).Where(w => w.UserId == UserId).Count();
            int pageSize = 5;
            int page_Num = count / pageSize;

            id = id == null ? 1 : id;
            TempData["prev"] = id > 1 ? id - 1 : null;
            TempData["next"] = id + 1;

            if (TempData["prev"] == null)//the first page
            {
                if (count == 0)//i make this condition because of not divided on zero in line number 49
                {
                    TempData["count"] = 0;
                    return View();
                }
                if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
                {
                    TempData["disabled_next"] = "disabled";
                }
                var first_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).Where(w => w.UserId == UserId).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_prev"] = "disabled";
                TempData["id"] = id;
                return View(first_page);
            }
            if ((count - ((id - 1) * pageSize) % count) <= pageSize)//the last page null
            {
                var last_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).Where(w => w.UserId == UserId).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
                TempData["disabled_next"] = "disabled";
                TempData["id"] = id;
                return View(last_page);
            }


            var move_page = luxuryDb.checked_in.Include(i => i.User).Include(n => n.IBooking).Where(w => w.UserId == id).Skip((id.Value - 1) * pageSize).Take(pageSize).ToList();
            id = id + 1;
            TempData["id"] = id;
            foreach(var item in move_page)
            {
               ViewBag.ibookAttr_checked= luxuryDb.iBookingAttributes.Where(w => w.IBookingId == item.IBookingId).ToList();
                
            }
            
            return View(move_page);
            ///////////////////////////////////////////////////// without pagination
           // var user=  luxuryDb.users.FirstOrDefault(f=>f.Id==id);
           // if (user == null)
           // {
           //     TempData["error_msg"] = "user is not found";
           //     return View($"{ViewPath}Index.cshtml");
           // }
           //     ViewBag.username=user.username;
           //     ViewBag.email=user.Email;
           //     ViewBag.phone = user.Phone;

           // if (id == null)
           // {
           //     TempData["error_msg"] = "Bad Request";
           //     return View($"{ViewPath}Index.cshtml");
           // }
           // var list_check_user=  luxuryDb.checked_in.Include(i=>i.User).Include(n=>n.IBooking).Where(w=>w.UserId == id).ToList();
           // if (list_check_user == null)
           // {
           //     TempData["error_msg"] = "There is no data for this user";
           //     return View($"{ViewPath}Index.cshtml");
           // }
           //ViewBag.Sum_Price= luxuryDb.checked_in.Where(w => w.UserId == id).Sum(s => s.amount);

           // return View(list_check_user);

        }

        #endregion

    }
}
