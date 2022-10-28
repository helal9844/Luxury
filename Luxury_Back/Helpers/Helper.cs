using Luxury_Back.Controllers.Admin;
using System.Globalization;

namespace Luxury_Back.Helpers
{
    public class Helper
    {
        public static string locale = CultureInfo.CurrentCulture.Name.StartsWith("ar")? "ar":"en";
    }
}
