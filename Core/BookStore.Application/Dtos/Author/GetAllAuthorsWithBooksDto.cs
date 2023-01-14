using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F = BookStore.Domain.Entities;
using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Author
{
    public class GetAllAuthorsWithBooksDto : BaseWriter
    {
        public ICollection<F.Book>? Books { get; set; }
    }
}