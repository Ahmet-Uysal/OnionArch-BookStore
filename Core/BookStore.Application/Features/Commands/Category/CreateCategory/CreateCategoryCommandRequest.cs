using MediatR;

namespace BookStore.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public string? Name { get; set; }
        public Guid? ParentId { get; set; }
    }

}