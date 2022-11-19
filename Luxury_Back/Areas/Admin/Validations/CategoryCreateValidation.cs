using FluentValidation;
using Luxury_Back.Controllers.Admin;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Areas.Admin.Validations
{
    public class CategoryCreateValidation : AbstractValidator<Category>
    {
        private readonly IStringLocalizer<CategoryController> localizer;
        public CategoryCreateValidation(IStringLocalizer<CategoryController> _localizer)
        {
            RuleFor(c => c.name_ar).NotNull()
                .WithMessage(localizer["category name empty"])
                .MinimumLength(2).WithMessage(localizer["minimumLength 2"]);
            RuleFor(c => c.name_en)
                .NotNull()
                .WithMessage(localizer["category name empty"])
                .MinimumLength(2).WithMessage(localizer["minimumLength 2"]);
        }
    }
}
