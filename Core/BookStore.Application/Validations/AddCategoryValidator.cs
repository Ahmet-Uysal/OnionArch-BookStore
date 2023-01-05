using BookStore.Application.Features.Commands.Category.AddCategory;
using FluentValidation;

namespace BookStore.Application.Validations
{
    public class AddCategoryValidator : AbstractValidator<AddCategoryCommandRequest>
    {
        public AddCategoryValidator()
        {
            _ = RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Bu alanın olması zorunludur");
        }
    }
}