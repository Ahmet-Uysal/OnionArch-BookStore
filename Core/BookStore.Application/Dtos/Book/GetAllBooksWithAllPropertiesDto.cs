using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Dtos.Category;
using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Book
{
    public class GetAllBooksWithAllPropertiesDto : BaseEntity
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