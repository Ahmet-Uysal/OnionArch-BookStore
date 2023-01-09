using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.SubscribeCategory
{
    public class SubscribeCategoryCommandHandler : BaseHandler<ICategoryReadRepository, ICategoryWriteRepository>, IRequestHandler<SubscribeCategoryCommandRequest, SubscribeCategoryCommandResponse>
    {
        public SubscribeCategoryCommandHandler(ICategoryReadRepository readRepository, ICategoryWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<SubscribeCategoryCommandResponse> Handle(SubscribeCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.ParentId = request.ParentId;
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}