using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions;
using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using F = BookStore.Domain.Entities;

namespace BookStore.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler : BaseHandler<IBookReadRepository, IBookWriteRepository>, IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
    {
        readonly IObjectOperations _objectOperations;
        readonly IAuthorReadRepository _authorReadRepository;
        public UpdateBookCommandHandler(IBookReadRepository readRepository, IBookWriteRepository writeRepository, IAuthorReadRepository authorReadRepository, IObjectOperations objectOperations) : base(readRepository, writeRepository)
        {
            _authorReadRepository = authorReadRepository;
            _objectOperations = objectOperations;
        }

        public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id, true, x => x.Authors);
            List<F.Author> authorList = _authorReadRepository.GetWhere(x => request.AuthorIds.Contains(x.Id)).ToList();
            _objectOperations.CopyProperties<UpdateBookCommandRequest, F.Book>(request, entity);
            entity.Authors = authorList;
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}