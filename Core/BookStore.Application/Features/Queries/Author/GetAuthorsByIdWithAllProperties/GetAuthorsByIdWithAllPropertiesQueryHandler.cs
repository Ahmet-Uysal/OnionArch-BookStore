using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithAllProperties
{
    public class GetAuthorsByIdWithAllPropertiesQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAuthorsByIdWithAllPropertiesQueryRequest, GetAuthorsByIdWithAllPropertiesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAuthorsByIdWithAllPropertiesQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAuthorsByIdWithAllPropertiesQueryResponse> Handle(GetAuthorsByIdWithAllPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAuthorsByIdWithAllPropertiesQueryResponse
            {
                Data = _mapper.Map<GetAuthorsByIdWithAllPropertiesDto>(await _readRepository.GetByIdAsync(request.Id, true, x => x.AuthorImageFiles, x => x.Books))
            };
        }
    }
}