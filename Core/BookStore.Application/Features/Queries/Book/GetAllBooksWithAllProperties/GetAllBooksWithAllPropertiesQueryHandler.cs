using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Book.GetAllBooksWithAllProperties
{
    public class GetAllBooksWithAllPropertiesQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetAllBooksWithAllPropertiesQueryRequest, GetAllBooksWithAllPropertiesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllBooksWithAllPropertiesQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllBooksWithAllPropertiesQueryResponse> Handle(GetAllBooksWithAllPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllBooksWithAllPropertiesQueryResponse
            {
                Data = _mapper.Map<List<GetAllBooksWithAllPropertiesDto>>(await _readRepository.GetAll().Include(x => x.Authors).Include(x => x.Category).ToListAsync())
            };
        }
    }
}