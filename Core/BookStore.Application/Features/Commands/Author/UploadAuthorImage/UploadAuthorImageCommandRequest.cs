using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookStore.Application.Features.Commands.Author.UploadAuthorImage
{
    public class UploadAuthorImageCommandRequest : BaseRequest, IRequest<UploadAuthorImageCommandResponse>
    {
        public IFormFileCollection Files { get; set; }
    }
}