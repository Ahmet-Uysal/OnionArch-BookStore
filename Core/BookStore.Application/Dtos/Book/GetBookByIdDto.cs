using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Book
{
    public class GetBookByIdDto : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
    }
}