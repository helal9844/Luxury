using Luxury_Back.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace Luxury_Back.Models;

[Index(nameof(name_ar), IsUnique = true)]
[Index(nameof(name_en), IsUnique = true)]
public class Category
{
    [Key]
    public int Id { get; set; }
    [DefaultValue(null)]
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    [Required]
    public string name_ar { get; set; }
    [Required]
    public string name_en { get; set; }
    [DefaultValue(0)]
    public bool IsActive { get; set; }
    public string? img_category { get; set; }
    public DateTime? Created_at { get; set; }
    public DateTime? Updated_at { get; set; }
    /*[Display(Name = "name")]
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
    }*/
    //public virtual ICollection<CategoryTranslation> translations { get; set; }
    public virtual ICollection<Category> childs { get; set; }
    public virtual ICollection<Brand> brands { get; set; }
    public virtual ICollection<IBooking> iBookings { get; set; }
    public virtual Category? parent { get; set; } = null!;
    public Category()
    {
        /*ranslations = new HashSet<CategoryTranslation>();*/
        childs = new HashSet<Category>();
        brands = new HashSet<Brand>();
        iBookings = new HashSet<IBooking>();
        /*parent = new Category();*/
    }
       
    
}
