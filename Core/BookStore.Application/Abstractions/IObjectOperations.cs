using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Application.Abstractions
{
    public interface IObjectOperations
    {
        void CopyProperties<T, E>(T source, E target) where T : class where E : class;
    }
}