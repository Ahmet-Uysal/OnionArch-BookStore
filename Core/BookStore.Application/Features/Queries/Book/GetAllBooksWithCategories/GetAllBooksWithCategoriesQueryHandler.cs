using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Book.GetAllBooksWithCategories
{
    public class GetAllBooksWithCategoriesQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetAllBooksWithCategoriesQueryRequest, GetAllBooksWithCategoriesQueryResponse>
    {
        readonly IMapper _mapper;

        public GetAllBooksWithCategoriesQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllBooksWithCategoriesQueryResponse> Handle(GetAllBooksWithCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllBooksWithCategoriesQueryResponse
            {
                Data = _mapper.Map<List<GetAllBooksWithCategoriesDto>>(await _readRepository.GetAll().Include(X => X.Category).ToListAsync())
            };
        }
    }
}