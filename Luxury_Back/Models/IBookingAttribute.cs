using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class IBookingAttribute
    {
        /*[Key]
        public int Id { get; set; }*/
        [ForeignKey("IBookingId")]
        public int? IBookingId { get; set; }
        [ForeignKey("IBookingId")]
        public int? IAttributeId { get; set; }
        [DefaultValue(0)]
        public string? value { get; set; }
        public virtual IBooking IBooking { get; set; }
        public virtual IAttribute IAttribute { get; set; }
    }
}
