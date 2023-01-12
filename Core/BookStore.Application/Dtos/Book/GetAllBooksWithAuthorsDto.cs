using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Dtos.Author;
using F = BookStore.Domain.Entities;

namespace BookStore.Application.Dtos.Book
{
    public class GetAllBooksWithAuthorsDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<GetAllAuthorDto>? Authors { get; set; }
    }
}