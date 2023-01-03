using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;
using BookStore.Persistence.Repositories;

namespace BookStore.Persistence.Repositories.AuthorRepository
{
    public class AuthorReadRepository : ReadRepository<AuthorImageFile>, IAuthorReadRepository
    {
        public AuthorReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}