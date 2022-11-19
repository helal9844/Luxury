using FluentValidation;
using Luxury_Back.Areas;
using Luxury_Back.Areas.Root.Controllers;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Validations.Users
{
    public class UserLoginValidation: AbstractValidator<User>
    {
        private readonly IStringLocalizer<AuthController> localizer;
        public UserLoginValidation(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;
            RuleFor(user =>user.Email)
                .NotNull().WithMessage(x => localizer["email"] + localizer["nullError"])
                .EmailAddress().WithMessage(localizer["erroremail"]);

            RuleFor(user => user.password)
                .NotNull().WithMessage(x => localizer["password"] + localizer["nullError"])
                .MinimumLength(8).WithMessage(localizer["pass_less_length"]);
           
        }
    }
}
