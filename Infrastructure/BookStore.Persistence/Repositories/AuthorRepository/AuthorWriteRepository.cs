using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.AuthorRepository
{
    public class AuthorWriteRepository : WriteRepository<Author>, IAuthorWriteRepository
    {
        public AuthorWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}