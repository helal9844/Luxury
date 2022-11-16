using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace Luxury_Back.Models
{

    public class Governorate
    {
        [Key]
        public int Id { get; set; }
        public string name_ar { get; set; }
        public string name_en { get; set; }
        public string? img_governorate { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public Governorate()
        {
            Cities = new HashSet<City>();
            Addresses = new HashSet<Address>();
        }
    }
}
