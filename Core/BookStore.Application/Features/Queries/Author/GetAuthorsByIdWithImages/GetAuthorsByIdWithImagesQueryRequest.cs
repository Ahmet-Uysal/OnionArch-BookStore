using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithImages
{
    public class GetAuthorsByIdWithImagesQueryRequest : BaseRequest, IRequest<GetAuthorsByIdWithImagesQueryResponse>
    {

    }
}