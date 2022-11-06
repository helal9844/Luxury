using Luxury_Back.Controllers.Admin;
//using Microsoft.AspNetCore.Mvc.Razor.RazorPages;
using System.Globalization;

namespace Luxury_Back.Helpers
{
    public class Helper
    {
        public static string getLnag()
        {
            return CultureInfo.CurrentCulture.Name.StartsWith("ar")?"ar":"en";
        }
       
        public static string? uploadeFile(IFormFile img, string? fileName)
        {
            string uniqueImge = DateTime.Now.ToString("yyyyyMMddHHmmss") + "." + img.FileName.Split(".")[1];
            if (!System.IO.Directory.Exists(@$".\wwwroot\images\{fileName}"))
            {
                System.IO.Directory.CreateDirectory(@$".\wwwroot\images\{fileName}");
            }
            using (var obj = new FileStream(@$".\wwwroot\images\{fileName}\" + uniqueImge, FileMode.Create))
            {
                img.CopyTo(obj);
            }
            return uniqueImge;
        }

        public static string? nameWithLang(string? name_ar, string? name_en)
        {
            return getLnag()=="ar"?name_ar:name_en;
        }

    }
}
