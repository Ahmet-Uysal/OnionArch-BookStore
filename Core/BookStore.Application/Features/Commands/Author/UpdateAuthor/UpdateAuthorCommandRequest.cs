using System.ComponentModel.DataAnnotations.Schema;
using BookStore.Domain.Entities.Common;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest : BaseWriter, IRequest<UpdateAuthorCommandResponse>
    {
    }
}