using FluentValidation;
using Luxury_Back.Controllers.Admin;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Admin.Validations
{
    public class IAttributeValidation : AbstractValidator<IAttribute>
    {
        private readonly IStringLocalizer<IAttributeController> localizer;
        public IAttributeValidation(IStringLocalizer<IAttributeController> _localizer)
        {
            localizer = _localizer;
            RuleFor(c => c.name_ar).NotNull()
                .WithMessage("Attribute Name Can't Be Empty")
                .MinimumLength(2).WithMessage("MinimumLength Can't Be less Than 2 letters");
            RuleFor(c => c.name_en)
                .NotNull()
                .WithMessage("Attribute Name Can't Be Empty")
                .MinimumLength(2).WithMessage("MinimumLength Can't Be less Than 2 letters");
        }
    }
}
