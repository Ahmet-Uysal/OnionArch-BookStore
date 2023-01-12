using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using F = BookStore.Domain.Entities;

namespace BookStore.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler : BaseHandler<IBookReadRepository, IBookWriteRepository>, IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
    {
        readonly IObjectOperations _objectOperations;
        public UpdateBookCommandHandler(IBookReadRepository readRepository, IBookWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            _objectOperations.CopyProperties<UpdateBookCommandRequest, F.Book>(request, entity);
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}