using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using F = BookStore.Domain.Entities;

namespace BookStore.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandHandler : BaseWriteHandler<IBookWriteRepository>, IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        readonly IMapper _mapper;
        readonly IAuthorReadRepository _authorReadRepository;
        public CreateBookCommandHandler(IBookWriteRepository writeRepository, IMapper mapper, IAuthorReadRepository authorReadRepository) : base(writeRepository)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            List<F.Author> authorList = _authorReadRepository.GetWhere(x => request.AuthorIds.Contains(x.Id)).ToList();
            F.Book book = _mapper.Map<F.Book>(request);
            book.Authors = authorList;
            await _writeRepository.AddAsync(book);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}