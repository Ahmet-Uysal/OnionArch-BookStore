using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Category.GetCategories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQueryRequest, GetCategoriesQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly IMapper _mapper;
        //readonly BookStoreDbContext _context;

        public GetCategoriesQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _mapper = mapper;
        }

        public async Task<GetCategoriesQueryResponse> Handle(GetCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var a = await _categoryReadRepository.sa();
            return new GetCategoriesQueryResponse
            {
                IsSuccess = true,
                Data = _mapper.Map<List<GetCategoriesDto>>(_categoryReadRepository.GetAll()),
                Message = null
            };
        }

    }
}