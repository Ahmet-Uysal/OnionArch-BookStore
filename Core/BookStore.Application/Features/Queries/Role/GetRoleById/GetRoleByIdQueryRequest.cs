using MediatR;

namespace BookStore.Application.Features.Queries.Role.GetRoleById
{
    public class GetRoleByIdQueryRequest : IRequest<GetRoleByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}