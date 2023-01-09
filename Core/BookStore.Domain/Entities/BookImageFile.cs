namespace BookStore.Domain.Entities
{
    public class BookImageFile : File
    {
        public ICollection<BookStockKeepUnit>? Books { get; set; }
    }
}