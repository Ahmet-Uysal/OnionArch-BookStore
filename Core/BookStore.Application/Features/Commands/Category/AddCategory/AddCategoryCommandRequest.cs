using MediatR;

namespace BookStore.Application.Features.Commands.Category.AddCategory
{
    public class AddCategoryCommandRequest : IRequest<AddCategoryCommandResponse>
    {
        public string? Name { get; set; }
        public Guid? ParentId { get; set; }
    }

}