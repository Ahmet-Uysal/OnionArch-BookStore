using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Category
{
    public class GetCategoriesIgnoreIncludes : BaseEntity
    {
        public string? Name { get; set; }
        public Guid? ParentId { get; set; }
    }
}