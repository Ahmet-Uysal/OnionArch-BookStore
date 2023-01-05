using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Domain.Entities;

namespace BookStore.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, GetCategoriesDto>();
            CreateMap<Category, GetCategoriesIgnoreIncludes>();
        }
    }
}