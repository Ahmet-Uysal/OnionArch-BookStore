using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.CategoryRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistence.Repositories.CategoryRepository
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        readonly BookStoreDbContext _context;
        public CategoryReadRepository(BookStoreDbContext context) : base(context)
        {
            _context = context;
        }
    }
}