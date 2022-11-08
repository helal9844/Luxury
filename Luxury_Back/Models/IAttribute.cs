using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Luxury_Back.Models
{
    [Index(nameof(name_ar), IsUnique = true)]
    [Index(nameof(name_en), IsUnique = true)]
    public class IAttribute
    {
        [Key]
        public int Id { get; set; }
        public string? name_ar { get; set; }
        public string? name_en { get; set; }
        [DefaultValue(1)]
        public bool IsActive { get; set; }
        [DefaultValue("checkbox")]
        public string? inputType { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public ICollection<IBooking>? iBookings { get; set; }
        public virtual ICollection<IBookingAttribute>? iBookingAttributes { get; set; }
        public IAttribute()
        {
            iBookings = new HashSet<IBooking>();
            iBookingAttributes = new HashSet<IBookingAttribute>();
        }
    }
}
