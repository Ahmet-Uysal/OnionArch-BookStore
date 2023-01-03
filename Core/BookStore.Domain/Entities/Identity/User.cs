using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Entities.Identity
{
    public class User : IdentityUser<string>
    {
        public string NameSurname { get; set; }
        public ICollection<UserBookStockKeepUnit> UsersBook { get; set; }
    }
}