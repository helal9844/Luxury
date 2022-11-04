using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class Address
    {
        public int Id { get; set; }

        [ForeignKey("IBookingId")]
        public int? IBookingId { get; set; }

        public string? address { get; set; }
        public double? lat { get; set; }
        public double? lng { get; set; }
        [ForeignKey("GovernorateId")]
        public int? GovernorateId { get; set; }
        [ForeignKey("CityId")]
        public int? CityId { get; set; }

        public City? City { get; set; }
        public Governorate? Governorate { get; set; }

        public IBooking? IBooking { get; set; }



    }
}
