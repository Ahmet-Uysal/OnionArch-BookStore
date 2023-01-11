namespace BookStore.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        bool Remove(T model);
        Task<bool> RemoveAsync(Guid id);
        bool RemoveRange(List<T> model);
        bool Update(T model);
        public Task<int> SaveAsync();

    }
}