
using Luxury_Back.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(null)]
        [ForeignKey("ParentId")]
        public int? ParentId { get; set; }
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
                    if (translation.locale == Helper.locale)
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
            childs = new HashSet<Category>();
            parent = new Category();
        }
    }
}
