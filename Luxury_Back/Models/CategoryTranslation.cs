using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class CategoryTranslation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string locale { get; set; }
    }
}
