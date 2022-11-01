using Luxury_Back.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace Luxury_Back.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(null)]
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        [DefaultValue(0)]
        public bool IsActive { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        [Display(Name = "name")]
        public string name
        {
            get
            {
                foreach (var translation in translations.ToList())
                {
                    if (translation.locale == Helper.getLnag())
                        return translation.Name;
                }
                return "";
            }
        }
        public virtual ICollection<CategoryTranslation> translations { get; set; }
        public virtual ICollection<Category> childs { get; set; }
        public virtual Category? parent { get; set; } = null!;
        public Category()
        {
            translations = new HashSet<CategoryTranslation>();
            //childs = new HashSet<Category>();
            /*parent = new Category();*/
        }
    }
}
