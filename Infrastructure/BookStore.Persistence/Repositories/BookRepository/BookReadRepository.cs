using BookStore.Application.Repositories.BookRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookRepository
{
    public class BookReadRepository : ReadRepository<Book>, IBookReadRepository
    {
        public BookReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}