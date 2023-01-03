using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.TranslatorRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.TranslatorRepository
{
    public class TranslatorReadRepository : ReadRepository<Translator>, ITranslatorReadRepository
    {
        public TranslatorReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}