using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Repositories.BookRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Book.GetBookByIdWithCategories
{
    public class GetBookByIdWithCategoriesQueryHandler : BaseReadHandler<IBookReadRepository>, IRequestHandler<GetBookByIdWithCategoriesQueryRequest, GetBookByIdWithCategoriesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetBookByIdWithCategoriesQueryHandler(IBookReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetBookByIdWithCategoriesQueryResponse> Handle(GetBookByIdWithCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetBookByIdWithCategoriesQueryResponse
            {
                Data = _mapper.Map<GetBookByIdWithCategoriesDto>(await _readRepository.GetByIdAsync(request.Id, true, x => x.Category))
            };
        }
    }
}