using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;

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
            return new GetCategoriesQueryResponse
            {
                IsSuccess = true,
                Data = _mapper.Map<List<GetCategoriesIgnoreIncludes>>(_categoryReadRepository.GetAll(false)),
                Message = null
            };
        }

    }
}