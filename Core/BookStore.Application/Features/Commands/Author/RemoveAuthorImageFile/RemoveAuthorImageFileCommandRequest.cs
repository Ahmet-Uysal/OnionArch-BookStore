using MediatR;

namespace BookStore.Application.Features.Commands.Author.RemoveAuthorImageFile
{
    public class RemoveAuthorImageFileCommandRequest : BaseRequest, IRequest<RemoveAuthorImageFileCommandResponse>
    {
        public Guid FileId { get; set; }
    }

}