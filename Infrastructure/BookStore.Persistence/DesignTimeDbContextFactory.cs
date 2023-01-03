using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace BookStore.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookStoreDbContext>
    {
        public BookStoreDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BookStoreDbContext> dbContextOptionsBuilder = new();
            //dbContextOptionsBuilder.UseMySQL(Configuration.ConnectionString);
            return new BookStoreDbContext(dbContextOptionsBuilder.Options);
        }
    }
}