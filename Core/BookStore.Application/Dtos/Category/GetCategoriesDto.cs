using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Category
{
    public class GetCategoriesDto : BaseEntity
    {
        public string? Name { get; set; }
        public Guid? ParentId { get; set; }

        public ICollection<GetCategoriesDto>? SubCategories { get; set; }
    }
}