using FluentValidation;
using Luxury_Back.Controllers.Admin;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Admin.Validations
{
    public class AdminLoginValidation : AbstractValidator<User>
    {
        private readonly IStringLocalizer<AuthController> localizer;
        public AdminLoginValidation(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;
            RuleFor(admin => admin.Email)
                .NotNull().WithMessage(x => localizer["email"] + localizer["nullError"])
                .EmailAddress().WithMessage("email not valid");

            RuleFor(admin => admin.password)
                .NotNull().WithMessage(x => localizer["password"] + localizer["nullError"])
                .MinimumLength(8).WithMessage("Minimum Length can't be less than 8 characters");
        }
    }
}
