using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Author : BaseWriter
    {
        public ICollection<Book> Books { get; set; }
        public ICollection<AuthorImageFile> AuthorImageFiles { get; set; }
    }
}