using MediatR;

namespace BookStore.Application.Features.Commands.Author.SwitchAuthorActiveState
{
    public class SwitchAuthorActiveStateCommandRequest : BaseRequest, IRequest<SwitchAuthorActiveStateCommandResponse>
    {

    }
}