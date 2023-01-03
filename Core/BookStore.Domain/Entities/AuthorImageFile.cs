using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class AuthorImageFile : File
    {
        public ICollection<Author> Authors { get; set; }
    }
}