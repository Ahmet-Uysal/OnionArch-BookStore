using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.TranslatorRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.TranslatorRepository
{
    public class TranslatorWriteRepository : WriteRepository<Translator>, ITranslatorWriteRepository
    {
        public TranslatorWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}