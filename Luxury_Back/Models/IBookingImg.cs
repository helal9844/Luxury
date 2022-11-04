using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class IBookingImg
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("IBookingId")]
        public int IBookingId { get; set; }

        public IBooking? booking { get; set; }

    }
}
