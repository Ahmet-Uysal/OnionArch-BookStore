using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;
using C = BookStore.Domain.Entities;
namespace BookStore.Application.Features.Commands.Category.AddCategory
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommandRequest, AddCategoryCommandResponse>
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public AddCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<AddCategoryCommandResponse> Handle(AddCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = new C.Category();
            category.ParentId = request.ParentId;
            category.Name = request.Name;
            await _categoryWriteRepository.AddAsync(category);
            await _categoryWriteRepository.SaveAsync();
            return new()
            {
                IsSuccess = true,
                Data = null,
                Message = null
            };
        }
    }
}