using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandHander : BaseHandler<IAuthorReadRepository, IAuthorWriteRepository>, IRequestHandler<RemoveAuthorCommandRequest, RemoveAuthorCommandResponse>
    {
        public RemoveAuthorCommandHander(IAuthorReadRepository readRepository, IAuthorWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<RemoveAuthorCommandResponse> Handle(RemoveAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.Remove();
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();

        }
    }
}