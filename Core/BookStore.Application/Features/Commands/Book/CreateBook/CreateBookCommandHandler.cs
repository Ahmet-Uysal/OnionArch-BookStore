using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using F = BookStore.Domain.Entities;

namespace BookStore.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandHandler : BaseWriteHandler<IBookWriteRepository>, IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        readonly IMapper _mapper;
        public CreateBookCommandHandler(IBookWriteRepository writeRepository, IMapper mapper) : base(writeRepository)
        {
            _mapper = mapper;
        }

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.AddAsync(_mapper.Map<F.Book>(request));
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}