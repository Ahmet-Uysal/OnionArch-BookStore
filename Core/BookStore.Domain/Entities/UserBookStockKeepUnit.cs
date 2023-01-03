using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;
using BookStore.Domain.Entities.Identity;
using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities
{
    public class UserBookStockKeepUnit : BaseEntity
    {
        public string LibrarianNote { get; set; }
        public DateTime CheckedOut { get; set; }
        public int Delay { get; set; }
        public double Fine { get; set; }
        public HealthState HealtState { get; set; }
        public BookStockKeepUnit Book { get; set; }
        public virtual User User { get; set; }
    }
}