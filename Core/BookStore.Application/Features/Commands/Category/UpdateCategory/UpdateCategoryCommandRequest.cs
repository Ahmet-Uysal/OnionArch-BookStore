using MediatR;

namespace BookStore.Application.Features.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandRequest : BaseRequest, IRequest<UpdateCategoryCommandResponse>
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}