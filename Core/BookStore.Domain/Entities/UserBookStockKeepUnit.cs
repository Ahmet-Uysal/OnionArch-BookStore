using BookStore.Domain.Entities.Common;
using BookStore.Domain.Entities.Identity;
using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities
{
    public class UserBookStockKeepUnit : BaseEntity
    {
        public string? LibrarianNote { get; set; }
        public DateTime CheckedOut { get; set; }
        public int Delay { get; set; }
        public double Fine { get; set; }
        public HealthState HealtState { get; set; }
        public Guid? BookStockKeepUnitId { get; set; }
        public BookStockKeepUnit? Book { get; set; }
        public Guid? UserId { get; set; }
        // [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}