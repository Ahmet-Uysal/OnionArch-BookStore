using BookStore.Application.Repositories.EndpointRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.EndpointRepository
{
    public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}