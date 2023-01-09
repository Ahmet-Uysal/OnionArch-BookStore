using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithBooks
{
    public class GetAuthorsByIdWithBooksQueryRequest : BaseRequest, IRequest<GetAuthorsByIdWithBooksQueryResponse>
    {

    }
}