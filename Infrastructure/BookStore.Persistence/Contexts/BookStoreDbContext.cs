using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using BookStore.Domain.Entities.Common;
using BookStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistence.Contexts
{
    public class BookStoreDbContext : IdentityDbContext<User, Role, Guid>
    {
        public BookStoreDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseMySql(Configuration.ConnectionString, ServerVersion.AutoDetect(Configuration.ConnectionString));
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorImageFile> AuthorImageFiles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImageFile> BookImageFiles { get; set; }
        public DbSet<BookStockKeepUnit> BookStockKeepUnits { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Endpoint> Endpoints { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<UserBookStockKeepUnit> UserBookSKUs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // builder.Entity<Category>()
            // .HasOne(s => s.Parent)
            // .WithMany(m => m.SubCategories)
            // .HasForeignKey(e => e.ParentId).IsRequired(false);
            //builder.Entity<Category>().has(m => m.Parent).WithMany(m => m.Children);
            builder.Entity<Category>(category =>
            {
                category.HasMany(c => c.SubCategories)
                .WithOne(c => c.Parent)
                .HasForeignKey(c => c.ParentId).IsRequired(false);
            });
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in entries)
            {
                // _ = data.State switch
                // {
                //     EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                //     EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                //     default break

                // };
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        data.Entity.ModifyDate = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}