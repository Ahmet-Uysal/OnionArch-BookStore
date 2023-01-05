using BookStore.Application.Repositories.CategoryRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.CategoryRepository
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        private readonly BookStoreDbContext _context;
        public CategoryReadRepository(BookStoreDbContext context) : base(context)
        {
            _context = context;
        }
    }
}