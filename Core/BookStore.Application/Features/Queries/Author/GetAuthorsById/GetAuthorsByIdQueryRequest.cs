using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthorsById
{
    public class GetAuthorsByIdQueryRequest : BaseRequest, IRequest<GetAuthorsByIdQueryResponse>
    {

    }
}