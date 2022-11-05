using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    [Index(nameof(name_ar), IsUnique = true)]
    [Index(nameof(name_en), IsUnique = true)]
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public string? name_ar { get; set; }
        public string? name_en { get; set; }
        public string? logo { get; set; }
        public virtual Category? category { get; set; }
        public virtual ICollection<IBooking> iBookings { get; set; }

        public Brand()
        {
            iBookings = new HashSet<IBooking>();
        }
    }
}