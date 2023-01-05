using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Entities.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<Endpoint>? Endpoints { get; set; }
    }
}