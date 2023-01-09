using BookStore.Domain.Entities.Common;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandRequest : BaseWriter, IRequest<CreateAuthorCommandResponse>
    {

    }
}