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
using Microsoft.Extensions.Configuration;
using BookStore.Application.Abstractions.Services.Authentications;
using BookStore.Application.Abstractions.Services;
using BookStore.Application.Services;
using BookStore.Persistence.Services;

namespace BookStore.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            _ = services.AddDbContext<BookStoreDbContext>(options =>
            {
                string? connectionString = configuration.GetConnectionString("SqlServer");
                options.UseSqlServer(connectionString);
                
            }
        );
            _ = services.AddIdentity<User, Role>(options =>
          {
              options.Password.RequiredLength = 3;
              options.Password.RequireNonAlphanumeric = false;
              options.Password.RequireDigit = false;
              options.Password.RequireLowercase = false;
              options.Password.RequireUppercase = false;
          }).AddEntityFrameworkStores<BookStoreDbContext>();
            _ = services.AddScoped<IAuthorImageFileReadRepository, AuthorImageFileReadRepository>();
            _ = services.AddScoped<IAuthorImageFileWriteRepository, AuthorImageFileWriteRepository>();

            _ = services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
            _ = services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();

            _ = services.AddScoped<IBookImageFileReadRepository, BookImageFileReadRepository>();
            _ = services.AddScoped<IBookImageFileWriteRepository, BookImageFileWriteRepository>();

            _ = services.AddScoped<IBookReadRepository, BookReadRepository>();
            _ = services.AddScoped<IBookWriteRepository, BookWriteRepository>();

            _ = services.AddScoped<IBookStockKeepUnitReadRepository, BookStockKeepUnitReadRepository>();
            _ = services.AddScoped<IBookStockKeepUnitWriteRepository, BookStockKeepUnitWriteRepository>();

            _ = services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            _ = services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            _ = services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            _ = services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();

            _ = services.AddScoped<IFileReadRepository, FileReadRepository>();
            _ = services.AddScoped<IFileWriteRepository, FileWriteRepository>();

            _ = services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            _ = services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            _ = services.AddScoped<IPublisherReadRepository, PublisherReadRepository>();
            _ = services.AddScoped<IPublisherWriteRepository, PublisherWriteRepository>();

            _ = services.AddScoped<ITranslatorReadRepository, TranslatorReadRepository>();
            _ = services.AddScoped<ITranslatorWriteRepository, TranslatorWriteRepository>();

            _ = services.AddScoped<IUserBookStockKeepUnitReadRepository, UserBookStockKeepUnitReadRepository>();
            _ = services.AddScoped<IUserBookStockKeepUnitWriteRepository, UserBookStockKeepUnitWriteRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            _ = services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();
        }
    }
}