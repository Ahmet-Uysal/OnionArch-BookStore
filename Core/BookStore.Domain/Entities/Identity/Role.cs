using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Entities.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<Endpoint>? Endpoints { get; set; }
    }
}