using MediatR;

namespace BookStore.Application.Features.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandRequest : BaseRequest, IRequest<RemoveAuthorCommandResponse>
    {
    }
}