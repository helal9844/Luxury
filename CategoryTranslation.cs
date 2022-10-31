
using System.ComponentModel;
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
        [MaxLength(10)]
        public string locale { get; set; }
        public virtual Category Category { get; set; }
    }
}
