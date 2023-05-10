using System.Linq.Expressions;

namespace BookStore.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : class
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(Guid id, bool tracking = true, params Expression<Func<T, object>>[] navigationPropertyPath);
    }
}