using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthorsWithAllProperties
{
    public class GetAllAuthorsWithAllPropertiesQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAllAuthorsWithAllPropertiesQueryRequest, GetAllAuthorsWithAllPropertiesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllAuthorsWithAllPropertiesQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllAuthorsWithAllPropertiesQueryResponse> Handle(GetAllAuthorsWithAllPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllAuthorsWithAllPropertiesQueryResponse
            {
                Data = _mapper.Map<List<GetAllAuthorsWithAllPropertiesDto>>(await _readRepository.GetAll().Include(X => X.Books).Include(x => x.AuthorImageFiles).ToListAsync())
            };
        }
    }
}