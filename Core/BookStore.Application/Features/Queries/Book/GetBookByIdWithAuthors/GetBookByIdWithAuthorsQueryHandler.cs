using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithAuthors
{
    public class GetBookByIdWithAuthorsQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetBookByIdWithAuthorsQueryRequest, GetBookByIdWithAuthorsQueryResponse>
    {
        readonly IMapper _mapper;
        public GetBookByIdWithAuthorsQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetBookByIdWithAuthorsQueryResponse> Handle(GetBookByIdWithAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetBookByIdWithAuthorsQueryResponse
            {
                Data = _mapper.Map<GetBookByIdWithAuthorsDto>(await _readRepository.GetByIdAsync(request.Id, true, x => x.Authors))
            };
        }
    }
}