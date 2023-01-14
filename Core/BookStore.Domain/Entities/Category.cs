using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        public Guid? ParentId { get; set; }

        public Category? Parent { get; set; }
        public ICollection<Category>? SubCategories { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}