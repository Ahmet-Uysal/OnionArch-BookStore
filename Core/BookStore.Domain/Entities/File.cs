using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class File : BaseEntity
    {
        public string? Path { get; set; }
        public string? Name { get; set; }
        public string? Storage { get; set; }
        [NotMapped]
        public override DateTime ModifyDate { get => base.ModifyDate; set => base.ModifyDate = value; }
    }
}