using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Author
{
    public class GetAllAuthorsWithImagesDto : BaseWriter
    {
        public ICollection<AuthorImageFile>? AuthorImageFiles { get; set; }
    }
}