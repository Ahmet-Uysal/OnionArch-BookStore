using MediatR;

namespace BookStore.Application.Features.Commands.Book.RemoveBook
{
    public class RemoveBookCommandRequest : BaseRequest, IRequest<RemoveBookCommandResponse>
    {

    }
}