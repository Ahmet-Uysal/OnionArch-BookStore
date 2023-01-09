using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.SwitchCategoryActiveStatus
{
    public class SwitchCategoryActiveStatusCommandHandler : BaseHandler<ICategoryReadRepository, ICategoryWriteRepository>, IRequestHandler<SwitchCategoryActiveStatusCommandRequest, SwitchCategoryActiveStatusCommandResponse>
    {
        public SwitchCategoryActiveStatusCommandHandler(ICategoryReadRepository readRepository, ICategoryWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<SwitchCategoryActiveStatusCommandResponse> Handle(SwitchCategoryActiveStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.IsActive = !entity.IsActive;
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}