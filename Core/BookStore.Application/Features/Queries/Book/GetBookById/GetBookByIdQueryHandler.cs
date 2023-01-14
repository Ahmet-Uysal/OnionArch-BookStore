using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookById
{
    public class GetBookByIdQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetBookByIdQueryRequest, GetBookByIdQueryResponse>
    {
        readonly IMapper _mapper;
        public GetBookByIdQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetBookByIdQueryResponse> Handle(GetBookByIdQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetBookByIdQueryResponse
            {
                Data = _mapper.Map<GetBookByIdDto>(await _readRepository.GetByIdAsync(request.Id))
            };
        }
    }
}