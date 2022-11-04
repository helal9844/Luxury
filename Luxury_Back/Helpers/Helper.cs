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
       
    }
}
