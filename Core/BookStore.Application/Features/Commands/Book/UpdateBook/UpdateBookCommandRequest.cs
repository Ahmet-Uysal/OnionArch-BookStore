using MediatR;

namespace BookStore.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandRequest : BaseRequest, IRequest<UpdateBookCommandResponse>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid CategoryId { get; set; }
        public List<Guid> AuthorIds { get; set; }
    }
}