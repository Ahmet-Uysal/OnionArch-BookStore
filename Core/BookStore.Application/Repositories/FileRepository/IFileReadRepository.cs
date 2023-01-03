using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F = BookStore.Domain.Entities;
namespace BookStore.Application.Repositories.FileRepository
{
    public interface IFileReadRepository : IReadRepository<F.File>
    {

    }
}