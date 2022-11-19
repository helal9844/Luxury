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
                .NotNull().WithMessage(localizer["category"]+' '+ localizer["not selected"]);

            RuleFor(i => i.Address.GovernorateId)
                .NotNull().WithMessage(localizer["Governorate"] + ' ' + localizer["not selected"]);

            RuleFor(i => i.Address.CityId)
                .NotNull().WithMessage(localizer["city"] + ' ' + localizer["not selected"]);

            RuleFor(i => i.Address.address)
                .NotNull().WithMessage(localizer["address"] + ' ' + localizer["not selected"]);
        }
    }
}
