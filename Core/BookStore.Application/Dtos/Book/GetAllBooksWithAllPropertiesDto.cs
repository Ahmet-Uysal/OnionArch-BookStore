using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Dtos.Category;

namespace BookStore.Application.Dtos.Book
{
    public class GetAllBooksWithAllPropertiesDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid CategoryId { get; set; }
        public GetCategoriesIgnoreIncludes? Category { get; set; }
        public ICollection<GetAllAuthorDto>? Authors { get; set; }
    }
}