using FluentValidation;
using Luxury_Back.Controllers.Admin;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Admin.Validations
{
    public class IBookingValidation : AbstractValidator<IBooking>
    {
        private readonly IStringLocalizer<IBookingController> localizer;
        public IBookingValidation(IStringLocalizer<IBookingController> _localizer)
        {
            localizer = _localizer;
            RuleFor(i => i.name_ar)
                .NotNull().WithMessage(x => $"{localizer["ar-EG"]} {localizer["name"]} {localizer["nullError"]}")
                .MinimumLength(4);

            RuleFor(i => i.name_en)
                .NotNull().WithMessage(x => $"{localizer["en-US"]} {localizer["name"]} {localizer["nullError"]}")
                .MinimumLength(4);

            RuleFor(i => i.description_ar)
                .NotNull().WithMessage(x => $"{localizer["ar-EG"]} {localizer["description"]} {localizer["nullError"]}")
                .MinimumLength(4);

            RuleFor(i => i.description_en)
                .NotNull().WithMessage(x => $"{localizer["en-US"]} {localizer["description"]} {localizer["nullError"]}")
                .MinimumLength(4);

            RuleFor(i => i.Category_Id)
                .NotNull().WithMessage("Category Not Selected");

            RuleFor(i => i.Address.GovernorateId)
                .NotNull().WithMessage("Governorate Not Selected");

            RuleFor(i => i.Address.CityId)
                .NotNull().WithMessage("City Not Selected");

            RuleFor(i => i.Address.address)
                .NotNull().WithMessage("Address Not Selected");
        }
    }
}
