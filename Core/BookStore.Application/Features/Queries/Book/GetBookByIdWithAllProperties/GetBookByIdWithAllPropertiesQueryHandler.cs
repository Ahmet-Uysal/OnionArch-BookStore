using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithAllProperties
{
    public class GetBookByIdWithAllPropertiesQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetBookByIdWithAllPropertiesQueryRequest, GetBookByIdWithAllPropertiesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetBookByIdWithAllPropertiesQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetBookByIdWithAllPropertiesQueryResponse> Handle(GetBookByIdWithAllPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetBookByIdWithAllPropertiesQueryResponse
            {
                Data = _mapper.Map<GetBookByIdWithAllPropertiesDto>(await _readRepository.GetByIdAsync(request.Id, true, x => x.Category, x => x.Authors))
            };
        }
    }
}