using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Entities.Identity
{
    public class User : IdentityUser<Guid>
    {
        public string? NameSurname { get; set; }
        public ICollection<UserBookStockKeepUnit>? UsersBook { get; set; }
    }
}