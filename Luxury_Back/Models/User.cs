using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Luxury_Back.Models
{
    [Index(nameof(username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Required]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required, MinLength(6, ErrorMessage ="MinLengthValidation")]
        public string? username { get; set; }

        [System.ComponentModel.DataAnnotations.Required, MinLength(8, ErrorMessage = "MinLengthValidation")]
        public string? password { get; set; }
        [NotMapped]
        public string? confirm_password { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [RegularExpression(@"^[A-Za-z0-9]+@([a-zA-Z]+\\.)+[a-zA-Z]{2,6}]&", ErrorMessage = "Email Not Corrict")]
        public string? Email { get; set; }
        [DefaultValue(null)]
        public bool? IsEmailVerify { get; set; }

        [MinLength(8, ErrorMessage = "MinLengthValidation")]
        [DefaultValue(null)]
        public string? Phone { get; set; }

        [DefaultValue(0)]
        public bool is_admin { get; set; }
        [DefaultValue(0)]
        public bool is_active { get; set; }
        [DefaultValue(null)]
        public DateTime? created_at { get; set; }
        [Timestamp]
        public DateTime? updated_at { get; set; }
        //navigation
        public Code_ForgetPass? code { get; set; }
        public User()
        {
            Checked_In=new HashSet<Checked_In>();
        }
        public virtual ICollection<Checked_In> Checked_In { get; set; }
    }
}
