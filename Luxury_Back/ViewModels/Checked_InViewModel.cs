using Luxury_Back.Models;

namespace Luxury_Back.ViewModels
{
    public class Checked_InViewModel
    {
        //public int count_checked { get; set; }
        //public int count_bookings { get; set; }
        //public int count_users { get; set; }
        //public int mount_checked { get; set; }
        public List<IBooking>? list_bookings { get; set; }
        public List<Checked_In>? newest_checked { get; set; }


    }
}
