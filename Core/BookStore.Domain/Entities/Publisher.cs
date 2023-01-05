using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public string? Name { get; set; }
        public string? GLN { get; set; }
        public string? PhoneNumber { get; set; }
    }
}