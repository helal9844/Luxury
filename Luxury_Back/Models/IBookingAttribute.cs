using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class IBookingAttribute
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IBookingId))]
        public int? IBookingId { get; set; }

        [DefaultValue(0)]
        public int? cost { get; set; }
        [DefaultValue(0)]
        public int? capacity { get; set; }
        [DefaultValue(0)]
        public int? space { get; set; }
        [DefaultValue(false)]
        public bool? city_view { get; set; }
        [DefaultValue(false)]
        public bool? kitchen { get; set; }
        [DefaultValue(false)]
        public bool? bath { get; set; }
        [DefaultValue(false)]
        public bool? p_bath { get; set; }
        [DefaultValue(false)]
        public bool? pool { get; set; }
        [DefaultValue(false)]
        public bool? conditioning { get; set; }
        [DefaultValue(false)]
        public bool? balcony { get; set; }
        [DefaultValue(false)]
        public bool? washing_m { get; set; }
        [DefaultValue(false)]
        public bool? wi_fi { get; set; }
        [DefaultValue(false)]
        public bool? room_service { get; set; }
        [DefaultValue(false)]
        public bool? parking { get; set; }
        [DefaultValue(false)]
        public bool? transfer_service { get; set; }

        public IBooking IBooking { get; set; }
    }
}
