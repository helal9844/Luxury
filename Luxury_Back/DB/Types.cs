using Luxury_Back.Controllers.Admin;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.DB
{
    public class Types
    {
        private readonly IStringLocalizer<IAttributeController> localizer;


        public Types(LuxuryDb luxuryDb, IStringLocalizer<IAttributeController> _localizer, LuxuryDb db)
        {
            this.localizer = _localizer;
        }
        public static readonly List<SelectListItem> iSelect =
            new List<SelectListItem>
            {
                new SelectListItem {Text = "Check Box", Value = "checkbox"},
                new SelectListItem {Text = "Text", Value = "text"}
            };
    }
}
