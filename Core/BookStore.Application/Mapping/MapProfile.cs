using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Dtos.Book;
using BookStore.Application.Dtos.Category;
using BookStore.Application.Features.Commands.Author.CreateAuthor;
using BookStore.Application.Features.Commands.Book.CreateBook;
using BookStore.Domain.Entities;

namespace BookStore.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            _ = CreateMap<Category, GetCategoriesDto>();
            _ = CreateMap<Category, GetCategoriesIgnoreIncludes>();
            _ = CreateMap<Category, GetAllCategoriesWithBooksDto>();

            _ = CreateMap<CreateAuthorCommandRequest, Author>();
            _ = CreateMap<Author, GetAllAuthorDto>();
            _ = CreateMap<Author, GetAuthorsByIdDto>();
            _ = CreateMap<Author, GetAllAuthorsWithBooksDto>();
            _ = CreateMap<Author, GetAllAuthorsWithImagesDto>();
            _ = CreateMap<Author, GetAuthorsByIdWithBooksDto>();
            _ = CreateMap<Author, GetAuthorsByIdWithImagesDto>();
            _ = CreateMap<Author, GetAllAuthorsWithAllPropertiesDto>();
            _ = CreateMap<Author, GetAuthorsByIdWithAllPropertiesDto>();
            _ = CreateMap<AuthorImageFile, GetAuthorImageFileDto>();

            _ = CreateMap<CreateBookCommandRequest, Book>();
            _ = CreateMap<Book, GetAllBookDto>();
            _ = CreateMap<Book, GetAllBooksWithAllPropertiesDto>();
            _ = CreateMap<Book, GetAllBooksWithAuthorsDto>();
            _ = CreateMap<Book, GetAllBooksWithCategoriesDto>();
            _ = CreateMap<Book, GetBookByIdDto>();
            _ = CreateMap<Book, GetBookByIdWithAllPropertiesDto>();
            _ = CreateMap<Book, GetBookByIdWithAuthorsDto>();
            _ = CreateMap<Book, GetBookByIdWithCategoriesDto>();



        }
    }
}