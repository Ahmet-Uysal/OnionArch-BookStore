using BookStore.Application.Repositories;
using BookStore.Domain.Entities.Common;
using BookStore.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly BookStoreDbContext _context;

        public WriteRepository(BookStoreDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T> entity = await Table.AddAsync(model);
            return entity.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T> entity = Table.Remove(model);
            return entity.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T? entity = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(entity);
        }
        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public bool Update(T model)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T> entity = Table.Update(model);
            return entity.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}