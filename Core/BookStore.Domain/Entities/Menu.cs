using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<Endpoint>? Endpoints { get; set; }
    }
}