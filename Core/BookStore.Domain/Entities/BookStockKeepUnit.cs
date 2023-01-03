using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;
using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities
{
    public class BookStockKeepUnit : BaseEntity
    {
        public int PageCount { get; set; }
        public VolumeType VolumeType { get; set; }
        public PaperType PaperType { get; set; }
        public Size Size { get; set; }
        public double BuyingPrice { get; set; }
        public CurrencyCode CurrencyCode { get; set; }
        public DateTime PublishDate { get; set; }
        public double DelayFactor { get; set; }
        public double DemageFactor { get; set; }
        public HealthState HealthState { get; set; }

        public Guid? BookId { get; set; }
        public Book Book { get; set; }
        public Guid? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookImageFile> BookImages { get; set; }
        public ICollection<Translator> Translators { get; set; }

    }
}