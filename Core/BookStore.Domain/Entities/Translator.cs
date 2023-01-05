using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Translator : BaseWriter
    {
        public ICollection<BookStockKeepUnit>? BookStockKeepUnits { get; set; }
    }
}