using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Repositories.AuthorRepository;
using F = BookStore.Domain.Entities;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandHandler : BaseWriteHandler<IAuthorWriteRepository>, IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
    {
        readonly IMapper _mapper;
        public CreateAuthorCommandHandler(IAuthorWriteRepository writeRepository, IMapper mapper) : base(writeRepository)
        {
            _mapper = mapper;
        }

        public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.AddAsync(_mapper.Map<F.Author>(request));
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}