using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthorsWithBooks
{
    public class GetAllAuthorsWithBooksQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAllAuthorsWithBooksQueryRequest, GetAllAuthorsWithBooksQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllAuthorsWithBooksQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllAuthorsWithBooksQueryResponse> Handle(GetAllAuthorsWithBooksQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllAuthorsWithBooksQueryResponse
            {
                Data = _mapper.Map<List<GetAllAuthorsWithBooksDto>>(await _readRepository.GetAll().Include(X => X.Books).ToListAsync())
            };
        }
    }
}