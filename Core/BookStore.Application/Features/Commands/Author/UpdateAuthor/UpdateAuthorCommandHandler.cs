using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions;
using BookStore.Application.Repositories.AuthorRepository;
using F = BookStore.Domain.Entities;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : BaseHandler<IAuthorReadRepository, IAuthorWriteRepository>, IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
    {
        readonly IObjectOperations _objectOperations;
        public UpdateAuthorCommandHandler(IAuthorReadRepository readRepository, IAuthorWriteRepository writeRepository, IObjectOperations objectOperations) : base(readRepository, writeRepository)
        {
            _objectOperations = objectOperations;
        }

        public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            _objectOperations.CopyProperties<UpdateAuthorCommandRequest, F.Author>(request, entity);
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}