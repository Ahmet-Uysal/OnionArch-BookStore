using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.SwitchAuthorActiveState
{
    public class SwitchAuthorActiveStateCommandHandler : BaseHandler<IAuthorReadRepository, IAuthorWriteRepository>, IRequestHandler<SwitchAuthorActiveStateCommandRequest, SwitchAuthorActiveStateCommandResponse>
    {
        public SwitchAuthorActiveStateCommandHandler(IAuthorReadRepository readRepository, IAuthorWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<SwitchAuthorActiveStateCommandResponse> Handle(SwitchAuthorActiveStateCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.SwitchState();
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}