using FluentValidation;
using Luxury_Back.Areas.Root.Controllers;
using Luxury_Back.Models;
using Luxury_Back.ViewModels;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Root.Validations
{
    public class UserResetPasswordValidation : AbstractValidator<Reset_Pass>
    {
        private readonly IStringLocalizer<AuthController> localizer;
        public UserResetPasswordValidation(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;

            RuleFor(user => user.Password)
                .NotNull().WithMessage(x => localizer["password"] + localizer["nullError"])
                .MinimumLength(8).WithMessage(localizer["pass_less_length"]);
            //.Matches("").WithMessage("please enter password strong"); //error in case of if i don't enter field confirm 

            RuleFor(user => user).Custom((user, context) =>
            {
                if (user.Password != user.Confirm_Password)
                {
                    context.AddFailure(nameof(user.Password), localizer["pass_not_match"]);
                }
            });




        }
    }
}
    

