using BookStore.Application.Repositories.BookStockKeepUnitRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookStockKeepUnitRepository
{
    public class BookStockKeepUnitWriteRepository : WriteRepository<BookStockKeepUnit>, IBookStockKeepUnitWriteRepository
    {
        public BookStockKeepUnitWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}