using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Domain.Entities;

namespace BookStore.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            _ = CreateMap<Category, GetCategoriesDto>();
            _ = CreateMap<Category, GetCategoriesIgnoreIncludes>();
        }
    }
}