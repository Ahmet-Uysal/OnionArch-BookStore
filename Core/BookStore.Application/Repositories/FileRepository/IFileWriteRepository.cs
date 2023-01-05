using F = BookStore.Domain.Entities;
namespace BookStore.Application.Repositories.FileRepository
{
    public interface IFileWriteRepository : IWriteRepository<F.File>
    {

    }
}