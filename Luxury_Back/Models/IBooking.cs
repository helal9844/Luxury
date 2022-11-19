using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models;
[Index(nameof(name_ar),IsUnique =true)]
[Index(nameof(name_en),IsUnique =true)]
public class IBooking
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Category_Id")]
    public int? Category_Id { get; set; }
    public int? BrandId { get; set; }
    
    public string? name_en { get; set; }
    public string? name_ar { get; set; }
    public string? description_en { get; set; }
    public string? description_ar { get; set; }
    public DateTime? created_at { get; set; }
    public DateTime? updated_at { get; set; }
    [DefaultValue(0)]
    public bool IsActive { get; set; }

    //RELATION
    public Category? Category { get; set; }
    public Brand? Brand { get; set; }
    public Address? Address { get; set; }
    /*public IBookingAttribute? attribute { get; set; }*/

    public ICollection<IBookingImg>? images { get; set; }

    public virtual ICollection<IAttribute>? iAttributes { get; set; }
    public virtual ICollection<IBookingAttribute>? iBookingAttributes { get; set; }

    public virtual ICollection<Checked_In>? Checked_In { get; set; }

    public IBooking()
    {
        //category = new Category();
        images = new HashSet<IBookingImg>();
        iAttributes = new HashSet<IAttribute>();
        iBookingAttributes = new HashSet<IBookingAttribute>();
        Checked_In=new HashSet<Checked_In>();
    }
}
