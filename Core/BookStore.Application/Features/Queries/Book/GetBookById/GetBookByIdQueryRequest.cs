using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookById
{
    public class GetBookByIdQueryRequest : BaseRequest, IRequest<GetBookByIdQueryResponse>
    {

    }
}