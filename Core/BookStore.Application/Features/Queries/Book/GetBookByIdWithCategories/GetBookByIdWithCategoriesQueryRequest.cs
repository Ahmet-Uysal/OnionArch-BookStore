using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithCategories
{
    public class GetBookByIdWithCategoriesQueryRequest : BaseRequest, IRequest<GetBookByIdWithCategoriesQueryResponse>
    {

    }
}