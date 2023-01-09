using BookStore.Application.Features.Commands.Category.CreateCategory;
using FluentValidation;

namespace BookStore.Application.Validations
{
    public class AddCategoryValidator : AbstractValidator<CreateCategoryCommandRequest>
    {
        public AddCategoryValidator()
        {
            _ = RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Bu alanın olması zorunludur");
        }
    }
}