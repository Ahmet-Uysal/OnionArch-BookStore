using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities.Common
{
    public class BaseWriter : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
    }
}