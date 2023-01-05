namespace BookStore.Domain.Entities.Common
{
    public class BaseWriter : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Biography { get; set; }
    }
}