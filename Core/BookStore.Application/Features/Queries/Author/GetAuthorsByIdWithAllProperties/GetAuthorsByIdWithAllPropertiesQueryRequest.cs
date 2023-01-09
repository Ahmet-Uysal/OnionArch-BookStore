using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithAllProperties
{
    public class GetAuthorsByIdWithAllPropertiesQueryRequest : BaseRequest, IRequest<GetAuthorsByIdWithAllPropertiesQueryResponse>
    {

    }
}