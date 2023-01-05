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
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<BaseEntity>> entries = ChangeTracker.Entries<BaseEntity>();
            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<BaseEntity> data in entries)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        data.Entity.ModifyDate = DateTime.UtcNow;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}