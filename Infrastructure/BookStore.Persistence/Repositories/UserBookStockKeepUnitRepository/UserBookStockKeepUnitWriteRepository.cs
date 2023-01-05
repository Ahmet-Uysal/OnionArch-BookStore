using BookStore.Application.Repositories.UserBookStockKeepUnitRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.UserBookStockKeepUnitRepository
{
    public class UserBookStockKeepUnitWriteRepository : WriteRepository<UserBookStockKeepUnit>, IUserBookStockKeepUnitWriteRepository
    {
        public UserBookStockKeepUnitWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}