using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Application.Features
{
    public class ApiResponse<T> where T : class
    {
        public bool IsSuccess { get; set; } = true;
        public T Data { get; set; } = null;
        public string Message { get; set; } = null;
    }
}