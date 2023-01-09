using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.RemoveCategory
{
    public class RemoveCategoryCommandHandler : BaseHandler<ICategoryReadRepository, ICategoryWriteRepository>, IRequestHandler<RemoveCategoryCommandRequest, RemoveCategoryCommandResponse>
    {
        public RemoveCategoryCommandHandler(ICategoryReadRepository readRepository, ICategoryWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<RemoveCategoryCommandResponse> Handle(RemoveCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.IsDeleted = true;
            entity.IsActive = true;
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}