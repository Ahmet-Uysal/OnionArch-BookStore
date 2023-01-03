using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<Endpoint>? Endpoints { get; set; }
    }
}