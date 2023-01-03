using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Identity;
using BookStore.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStore.Application.Repositories.AuthorImageFileRepository;
using BookStore.Application.Repositories.AuthorRepository;
using BookStore.Application.Repositories.BookImageFileRepository;
using BookStore.Application.Repositories.BookRepository;
using BookStore.Application.Repositories.BookStockKeepUnitRepository;
using BookStore.Application.Repositories.CategoryRepository;
using BookStore.Application.Repositories.EndpointRepository;
using BookStore.Application.Repositories.FileRepository;
using BookStore.Application.Repositories.MenuRepository;
using BookStore.Application.Repositories.PublisherRepository;
using BookStore.Application.Repositories.TranslatorRepository;
using BookStore.Application.Repositories.UserBookStockKeepUnitRepository;


using BookStore.Persistence.Repositories.AuthorRepository;
using BookStore.Persistence.Repositories.BookImageFileRepository;
using BookStore.Persistence.Repositories.BookRepository;
using BookStore.Persistence.Repositories.BookStockKeepUnitRepository;
using BookStore.Persistence.Repositories.CategoryRepository;
using BookStore.Persistence.Repositories.EndpointRepository;
using BookStore.Persistence.Repositories.FileRepository;
using BookStore.Persistence.Repositories.MenuRepository;
using BookStore.Persistence.Repositories.PublisherRepository;
using BookStore.Persistence.Repositories.TranslatorRepository;
using BookStore.Persistence.Repositories.UserBookStockKeepUnitRepository;
using BookStore.Persistence.Repositories.AuthorImageFileRepository;

namespace BookStore.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BookStoreDbContext>(options =>
                       options.UseMySql(Configuration.ConnectionString, ServerVersion.AutoDetect(Configuration.ConnectionString))
                       );
            services.AddIdentity<User, Role>(options =>
          {
              options.Password.RequiredLength = 3;
              options.Password.RequireNonAlphanumeric = false;
              options.Password.RequireDigit = false;
              options.Password.RequireLowercase = false;
              options.Password.RequireUppercase = false;
          }).AddEntityFrameworkStores<BookStoreDbContext>();
            services.AddScoped<IAuthorImageFileReadRepository, AuthorImageFileReadRepository>();
            services.AddScoped<IAuthorImageFileWriteRepository, AuthorImageFileWriteRepository>();

            services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
            services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();

            services.AddScoped<IBookImageFileReadRepository, BookImageFileReadRepository>();
            services.AddScoped<IBookImageFileWriteRepository, BookImageFileWriteRepository>();

            services.AddScoped<IBookReadRepository, BookReadRepository>();
            services.AddScoped<IBookWriteRepository, BookWriteRepository>();

            services.AddScoped<IBookStockKeepUnitReadRepository, BookStockKeepUnitReadRepository>();
            services.AddScoped<IBookStockKeepUnitWriteRepository, BookStockKeepUnitWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();

            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();

            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            services.AddScoped<IPublisherReadRepository, PublisherReadRepository>();
            services.AddScoped<IPublisherWriteRepository, PublisherWriteRepository>();

            services.AddScoped<ITranslatorReadRepository, TranslatorReadRepository>();
            services.AddScoped<ITranslatorWriteRepository, TranslatorWriteRepository>();

            services.AddScoped<IUserBookStockKeepUnitReadRepository, UserBookStockKeepUnitReadRepository>();
            services.AddScoped<IUserBookStockKeepUnitWriteRepository, UserBookStockKeepUnitWriteRepository>();
        }
    }
}