using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Luxury_Back.Models
{
    [Index(nameof(name_ar), IsUnique = true)]
    [Index(nameof(name_en), IsUnique = true)]
    public class IAttribute
    {
        public int Id { get; set; }
        public string? name_ar { get; set; }
        public string? name_en { get; set; }
        [DefaultValue(0)]
        public bool IsActive { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public ICollection<IBooking>? iBookings { get; set; }
        public IAttribute()
        {
            iBookings = new HashSet<IBooking>();
        }
    }
}
