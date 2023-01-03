using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.BookImageFileRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookImageFileRepository
{
    public class BookImageFileWriteRepository : WriteRepository<BookImageFile>, IBookImageFileWriteRepository
    {
        public BookImageFileWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}