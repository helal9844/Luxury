using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class Code_ForgetPass
    {
        [Key]
       public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
       public string? Code { get; set; }

        //navigation
        public User? user { get; set; }

    }
}
