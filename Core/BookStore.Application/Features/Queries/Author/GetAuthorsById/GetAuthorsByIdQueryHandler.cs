using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Features;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthorsById
{
    public class GetAuthorsByIdQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAuthorsByIdQueryRequest, GetAuthorsByIdQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAuthorsByIdQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAuthorsByIdQueryResponse> Handle(GetAuthorsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAuthorsByIdQueryResponse
            {
                Data = _mapper.Map<GetAuthorsByIdDto>(await _readRepository.GetByIdAsync(request.Id))
            };
        }
    }
}