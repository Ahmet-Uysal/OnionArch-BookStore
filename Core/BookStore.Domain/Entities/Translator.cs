using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Translator : BaseWriter
    {
        public ICollection<BookStockKeepUnit> BookStockKeepUnits { get; set; }
    }
}