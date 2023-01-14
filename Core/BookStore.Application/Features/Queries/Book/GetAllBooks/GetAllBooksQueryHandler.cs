using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetAllBooks
{
    public class GetAllBooksQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetAllBooksQueryRequest, GetAllBooksQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllBooksQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllBooksQueryResponse> Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllBooksQueryResponse
            {
                Data = _mapper.Map<List<GetAllBookDto>>(_readRepository.GetAll())
            };
        }
    }
}