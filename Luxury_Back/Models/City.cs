using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace Luxury_Back.Models
{

    public class City
    {
        [Key]
        public int Id { get; set; }
        public string name_ar { get; set; }
        public string name_en { get; set; }
        [ForeignKey("Governorate")]
        public int gov_id { get; set; }

        public virtual Governorate Governorate { get; set; }
        public City()
        {
            Addresses = new HashSet<Address>();
        }
        public virtual ICollection<Address>? Addresses { get; set; }

       

    }
}
