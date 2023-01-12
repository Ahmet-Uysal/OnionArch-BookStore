using MediatR;

namespace BookStore.Application.Features.Commands.Book.SwitchBookActiveState
{
    public class SwitchBookActiveStateCommandRequest : BaseRequest, IRequest<SwitchBookActiveStateCommandResponse>
    {

    }
}