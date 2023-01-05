using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Application.Features
{
    public abstract class BaseHandler<T, E> where T : class where E : class
    {
        protected T _readRepository;
        protected E _writeRepository { get; set; }
        public BaseHandler(T readRepository, E writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }
    }
    public abstract class BaseReadHandler<T> : Attribute where T : class
    {
        protected T _readRepository { get; set; }

        public BaseReadHandler(T readRepository)
        {
            _readRepository = readRepository;
        }
    }
    public abstract class BaseWriteHandler<E> where E : class
    {
        protected E _writeRepository { get; set; }

        public BaseWriteHandler(E writeRepository)
        {
            _writeRepository = writeRepository;
        }
    }
}