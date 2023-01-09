using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Features;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthors
{
    public class GetAllAuthorsQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAllAuthorsQueryRequest, GetAllAuthorsQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllAuthorsQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllAuthorsQueryResponse> Handle(GetAllAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllAuthorsQueryResponse
            {
                Data = _mapper.Map<List<GetAllAuthorDto>>(_readRepository.GetAll())
            };
        }
    }
}