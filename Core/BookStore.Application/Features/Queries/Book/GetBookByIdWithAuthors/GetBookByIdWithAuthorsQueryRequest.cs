using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithAuthors
{
    public class GetBookByIdWithAuthorsQueryRequest : BaseRequest, IRequest<GetBookByIdWithAuthorsQueryResponse>
    {

    }
}