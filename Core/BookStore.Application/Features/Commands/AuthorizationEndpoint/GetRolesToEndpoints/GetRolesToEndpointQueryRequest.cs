using MediatR;

namespace BookStore.Application.Features.Commands.AuthorizationEndpoint.GetRolesToEndpoints
{
    public class GetRolesToEndpointQueryRequest : IRequest<GetRolesToEndpointQueryResponse>
    {
        public string? Code { get; set; }
        public string? Menu { get; set; }
    }
}