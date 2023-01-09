using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.AuthorRepository
{
    public class AuthorReadRepository : ReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}