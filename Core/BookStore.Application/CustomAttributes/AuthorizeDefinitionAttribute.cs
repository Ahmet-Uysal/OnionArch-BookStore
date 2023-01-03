using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Enums;

namespace BookStore.Application.CustomAttributes
{
    public class AuthorizeDefinitionAttribute
    {
        public string? Menu { get; set; }
        public string? Definition { get; set; }
        public ActionType ActionType { get; set; }
    }
}