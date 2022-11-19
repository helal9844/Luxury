using FluentValidation;
using Luxury_Back.Areas;
using Luxury_Back.Areas.Root.Controllers;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back
{
    public class UserRegisterValidation : AbstractValidator<User>
    {
        private readonly IStringLocalizer<AuthController> localizer;
        public UserRegisterValidation(IStringLocalizer<AuthController> _localizer)
        {
            localizer = _localizer;

            RuleFor(user => user.username)
               .NotNull().WithMessage(x => localizer["username"] + localizer["nullError"])
               .MinimumLength(8).WithMessage(localizer["pass_less_length"]);

            RuleFor(user => user.Email)
                .NotNull().WithMessage(x => localizer["email"] + localizer["nullError"])
                .EmailAddress().WithMessage(localizer["erroremail"]);
           // .Matches(@"^[A-Za-z0-9]+@([a-zA-Z]+\\.)+[a-zA-Z]{2,6}]&").WithMessage("email not valid please enter strong email");
          
            RuleFor(user => user.password)
                .NotNull().WithMessage(x => localizer["password"] + localizer["nullError"])
                .MinimumLength(8).WithMessage(localizer["pass_less_length"]);
            //.Matches("").WithMessage("please enter password strong");

            RuleFor(user => user).Custom((user, context) =>
            {
                if (user.password != user.confirm_password)
                {
                    context.AddFailure(nameof(user.password), localizer["pass_not_match"]);
                }
            });
                

                //.Matches(user => user.password).WithMessage("Does Not Match With Password");

            // RuleFor(user => user.Phone!=null? user.Phone.ToString(): string.Empty)

            //.MinimumLength(11).WithMessage("Minimum Length can't be less than 11 characters");

        }
    }
}



