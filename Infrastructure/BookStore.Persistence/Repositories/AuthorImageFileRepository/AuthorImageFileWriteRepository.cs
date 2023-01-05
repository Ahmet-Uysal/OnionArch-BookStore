using BookStore.Application.Repositories.AuthorImageFileRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.AuthorImageFileRepository
{
    public class AuthorImageFileWriteRepository : WriteRepository<AuthorImageFile>, IAuthorImageFileWriteRepository
    {
        public AuthorImageFileWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}