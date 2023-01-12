using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Book.GetAllBooksWithAuthors
{
    public class GetAllBooksWithAuthorsQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetAllBooksWithAuthorsQueryRequest, GetAllBooksWithAuthorsQueryResponse>
    {
        readonly IMapper _mapper;

        public GetAllBooksWithAuthorsQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllBooksWithAuthorsQueryResponse> Handle(GetAllBooksWithAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllBooksWithAuthorsQueryResponse
            {
                Data = _mapper.Map<List<GetAllBooksWithAuthorsDto>>(await _readRepository.GetAll().Include(X => X.Authors).ToListAsync())
            };
        }
    }
}