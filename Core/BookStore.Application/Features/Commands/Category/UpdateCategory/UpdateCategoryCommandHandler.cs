using BookStore.Application.Abstractions;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;
using C = BookStore.Domain.Entities;
namespace BookStore.Application.Features.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandHandler : BaseHandler<ICategoryReadRepository, ICategoryWriteRepository>, IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        readonly IObjectOperations _objectOperations;
        public UpdateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository, Abstractions.IObjectOperations objectOperations)
: base(categoryReadRepository, categoryWriteRepository)
        {
            _objectOperations = objectOperations;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            _objectOperations.CopyProperties<UpdateCategoryCommandRequest, C.Category>(request, entity);
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}