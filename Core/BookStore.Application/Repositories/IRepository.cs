using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}