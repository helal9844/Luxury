using Luxury_Back.Controllers.Admin;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Microsoft.AspNetCore.Mvc.Razor.RazorPages;
using System.Globalization;
using System.Numerics;

namespace Luxury_Back.Helpers
{
    public class Helper
    {
        public static string getLnag()
        {
            return CultureInfo.CurrentCulture.Name.StartsWith("ar")?"ar":"en";
        }
       
        public static string? uploadeFile(IFormFile img, string? dirName)
        {
            Random rand = new Random();
            var r = rand.Next(1000, int.Parse(DateTime.Now.ToString("yyyyyMMmmss"))).ToString();
            string uniqueImge = r + "." + img.FileName.Split(".")[1];
            if (!System.IO.Directory.Exists(@$".\wwwroot\images\uploaded\{dirName}"))
            {
                System.IO.Directory.CreateDirectory(@$".\wwwroot\images\uploaded\{dirName}");
            }
            using (var obj = new FileStream(@$".\wwwroot\images\uploaded\{dirName}\" + uniqueImge, FileMode.Create))
            {
                img.CopyTo(obj);
            }
            return dirName !=null ? @$"{dirName}/{uniqueImge}": uniqueImge;
        }

        public static string? imageUrl(string? image)
        {
            if(image == null)
                return @"/images/DefaultImage.png";
            if (image.StartsWith("http") || image.StartsWith("https"))
            {
                return image;
            }
            return $@"/images/uploaded/{image}";
        }

        public static string? nameWithLang(string? name_ar, string? name_en)
        {
            return getLnag()=="ar"?name_ar:name_en;
        }

    }
}
