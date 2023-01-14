using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Book.SwitchBookActiveState
{
    public class SwitchBookActiveStateCommandHandler : BaseHandler<IBookReadRepository, IBookWriteRepository>, IRequestHandler<SwitchBookActiveStateCommandRequest, SwitchBookActiveStateCommandResponse>
    {
        public SwitchBookActiveStateCommandHandler(IBookReadRepository readRepository, IBookWriteRepository writeRepository) : base(readRepository, writeRepository)
        {
        }

        public async Task<SwitchBookActiveStateCommandResponse> Handle(SwitchBookActiveStateCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _readRepository.GetByIdAsync(request.Id);
            entity.SwitchState();
            _writeRepository.Update(entity);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}