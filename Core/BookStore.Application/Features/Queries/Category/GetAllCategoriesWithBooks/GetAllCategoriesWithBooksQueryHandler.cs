using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Category.GetAllCategoriesWithBooks
{
    public class GetAllCategoriesWithBooksQueryHandler : IRequestHandler<GetAllCategoriesWithBooksQueryRequest, GetAllCategoriesWithBooksQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly IMapper _mapper;

        public GetAllCategoriesWithBooksQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCategoriesWithBooksQueryResponse> Handle(GetAllCategoriesWithBooksQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllCategoriesWithBooksQueryResponse
            {
                IsSuccess = true,
                Data = _mapper.Map<List<GetAllCategoriesWithBooksDto>>(_categoryReadRepository.GetAll().Include(x => x.Books).ToList().Where(x => x.ParentId == null)),
                Message = null
            };
        }


    }
}