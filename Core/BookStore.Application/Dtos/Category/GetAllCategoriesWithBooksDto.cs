using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Dtos.Book;

namespace BookStore.Application.Dtos.Category
{
    public class GetAllCategoriesWithBooksDto
    {
        public string? Name { get; set; }
        public Guid? ParentId { get; set; }
        public ICollection<GetAllBookDto> Books { get; set; }
    }
}