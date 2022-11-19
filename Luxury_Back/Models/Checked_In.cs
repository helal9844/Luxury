using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Packaging.Signing;

namespace Luxury_Back.Models
{
    public class Checked_In
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("IBookingId")]
        public int IBookingId { get; set; }
        [DefaultValue(0)]
        public int amount { get; set; }
        [DefaultValue(0)]
        public int nights_count { get; set; }
        public DateTime checked_in { get; set; }
        public DateTime checked_out { get; set; }
       
        public DateTime? created_at { get; set; }//getdate now fluentapi
        public DateTime? updated_at { get; set; }
        //navigation property
        public virtual User? User { get; set; }
        public virtual IBooking? IBooking { get; set; }

    }
}
