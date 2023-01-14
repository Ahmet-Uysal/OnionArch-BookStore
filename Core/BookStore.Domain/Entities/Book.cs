using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Author>? Authors { get; set; }
    }
}