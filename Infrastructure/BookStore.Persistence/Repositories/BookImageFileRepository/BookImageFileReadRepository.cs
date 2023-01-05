using BookStore.Application.Repositories.BookImageFileRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookImageFileRepository
{
    public class BookImageFileReadRepository : ReadRepository<BookImageFile>, IBookImageFileReadRepository
    {
        public BookImageFileReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}