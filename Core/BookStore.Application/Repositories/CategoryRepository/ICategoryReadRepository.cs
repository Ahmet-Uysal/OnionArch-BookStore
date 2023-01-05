using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories.CategoryRepository
{
    public interface ICategoryReadRepository : IReadRepository<Category>
    {
    }
}