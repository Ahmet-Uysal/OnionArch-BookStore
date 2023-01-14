using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithAllProperties
{
    public class GetBookByIdWithAllPropertiesQueryRequest : BaseRequest, IRequest<GetBookByIdWithAllPropertiesQueryResponse>
    {

    }
}