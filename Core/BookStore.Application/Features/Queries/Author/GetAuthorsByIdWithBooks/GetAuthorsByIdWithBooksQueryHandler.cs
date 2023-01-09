using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithBooks
{
    public class GetAuthorsByIdWithBooksQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAuthorsByIdWithBooksQueryRequest, GetAuthorsByIdWithBooksQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAuthorsByIdWithBooksQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAuthorsByIdWithBooksQueryResponse> Handle(GetAuthorsByIdWithBooksQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAuthorsByIdWithBooksQueryResponse
            {
                Data = _mapper.Map<GetAuthorsByIdWithBooksDto>(await _readRepository.GetByIdAsync(request.Id, navigationPropertyPath: x => x.Books))
            };
        }
    }
}