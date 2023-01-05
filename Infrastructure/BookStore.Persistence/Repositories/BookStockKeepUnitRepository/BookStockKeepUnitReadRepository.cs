using BookStore.Application.Repositories.BookStockKeepUnitRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookStockKeepUnitRepository
{
    public class BookStockKeepUnitReadRepository : ReadRepository<BookStockKeepUnit>, IBookStockKeepUnitReadRepository
    {
        public BookStockKeepUnitReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}