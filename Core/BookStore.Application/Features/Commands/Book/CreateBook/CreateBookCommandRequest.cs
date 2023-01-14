using MediatR;

namespace BookStore.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid CategoryId { get; set; }
        public List<Guid> AuthorIds { get; set; }
    }
}