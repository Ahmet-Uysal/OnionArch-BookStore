using BookStore.Application.Repositories.UserBookStockKeepUnitRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.UserBookStockKeepUnitRepository
{
    public class UserBookStockKeepUnitReadRepository : ReadRepository<UserBookStockKeepUnit>, IUserBookStockKeepUnitReadRepository
    {
        public UserBookStockKeepUnitReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}