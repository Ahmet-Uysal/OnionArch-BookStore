using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Features.Commands.Category.AddCategory;
using FluentValidation;

namespace BookStore.Application.Validations
{
    public class AddCategoryValidator : AbstractValidator<AddCategoryCommandRequest>
    {
        public AddCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Bu alanın olması zorunludur");
        }
    }
}