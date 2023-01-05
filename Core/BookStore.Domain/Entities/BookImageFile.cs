namespace BookStore.Domain.Entities
{
    public class BookImageFile : File
    {
        public ICollection<Book>? Books { get; set; }
    }
}