using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Book.RemoveBook
{
    public class RemoveBookCommandHandler : BaseHandler<IBookReadRepository, IBookWriteRepository>, IRequestHandler<RemoveBookCommandRequest, RemoveBookCommandResponse>
    {

        public RemoveBookCommandHandler(IBookReadRepository readRepository, IBookWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<RemoveBookCommandResponse> Handle(RemoveBookCommandRequest request, CancellationToken cancellationToken)
        {

            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.Remove();
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }


    }
}