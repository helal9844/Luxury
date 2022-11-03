using FluentValidation;
using Luxury_Back.Controllers.Admin;
using Luxury_Back.Models;
using Microsoft.Extensions.Localization;

namespace Luxury_Back.Validations.admin
{
    public class CategoryCreateValidation: AbstractValidator<Category>
    {
        private readonly IStringLocalizer<CategoryController> localizer;
        public CategoryCreateValidation(IStringLocalizer<CategoryController> _localizer)
        {
            RuleFor(c => c.name_ar).NotNull()
                .WithMessage("Category Name Can't Be Empty")
                .MinimumLength(2).WithMessage("MinimumLength Can't Be less Than 2 letters");
            RuleFor(c => c.name_en)
                .NotNull()
                .WithMessage("Category Name Can't Be Empty")
                .MinimumLength(2).WithMessage("MinimumLength Can't Be less Than 2 letters");
        }
    }
}
