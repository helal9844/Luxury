using FluentValidation;
using Luxury_Back.Areas.Root.Controllers;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Validations
{
    public class UserUpdateProfileValidation :AbstractValidator<User>
    {
         private readonly IStringLocalizer<AuthController> localizer;
        public UserUpdateProfileValidation(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;

            RuleFor(user => user.username) 
               .NotNull().WithMessage(x => localizer["username"] + localizer["nullError"])
               .MinimumLength(8).WithMessage(localizer["pass_less_length"]);

            RuleFor(user => user.Email)
                .NotNull().WithMessage(x => localizer["email"] + localizer["nullError"])
                .EmailAddress().WithMessage("email not valid");

             RuleFor(user => user.Phone)
                .NotNull().WithMessage(x => localizer["phone"] + localizer["nullError"])
                .MinimumLength(11).WithMessage(localizer["error_phone"]);
        }
    }
}
