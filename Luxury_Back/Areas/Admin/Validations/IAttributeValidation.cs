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
                .WithMessage(localizer["Attribute Name"])
                .MinimumLength(2).WithMessage(localizer["minimumLength 2"]);
            RuleFor(c => c.name_en)
                .NotNull()
                .WithMessage(localizer["Attribute Name"])
                .MinimumLength(2).WithMessage(localizer["minimumLength 2"]);
        }
    }
}
