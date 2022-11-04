using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxury_Back.Models;
public class IBooking
{
    [Key]
    public int Id { get; set; }
    [Required]
    [ForeignKey("Category_Id")]
    public int? Category_Id { get; set; }
    [DefaultValue(0)]
    public int? cost { get; set; }
    [DefaultValue(0)]
    public int? capacity { get; set; }
    [DefaultValue(0)]
    public int? space { get; set; }
    [DefaultValue(false)]
    public bool? kitchen { get; set; }
    [DefaultValue(false)]
    public bool? pool { get; set; }
    [DefaultValue(false)]
    public bool? bath { get; set; }
    [DefaultValue(false)]
    public bool? conditioning { get; set; }
    [DefaultValue(false)]
    public bool? w_m { get; set; }
    [DefaultValue(false)]
    public bool? wi_fi { get; set; }
    [DefaultValue(false)]
    public bool? parking { get; set; }
    public DateTime? created_at { get; set; }
    public DateTime? updated_at { get; set; }

    public Category? category { get; set; }

    public IBooking()
    {
        //category = new Category();
    }
}
