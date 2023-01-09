using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.UnsubscribeCategory
{
    public class UnsubscribeCategoryCommandHandler : BaseHandler<ICategoryReadRepository, ICategoryWriteRepository>, IRequestHandler<UnsubscribeCategoryCommandRequest, UnsubscribeCategoryCommandResponse>
    {
        public UnsubscribeCategoryCommandHandler(ICategoryReadRepository readRepository, ICategoryWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<UnsubscribeCategoryCommandResponse> Handle(UnsubscribeCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.ParentId = null;
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}