using BookStore.Application.Abstractions;
using BookStore.Application.Abstractions.Services.Configurations;
using BookStore.Application.Abstractions.Storage;
using BookStore.Application.Abstractions.Token;
using BookStore.Application.Services;
using BookStore.Infrastructure.Enums;
using BookStore.Infrastructure.Services;
using BookStore.Infrastructure.Services.Configurations;
using BookStore.Infrastructure.Services.Storage;
using BookStore.Infrastructure.Services.Storage.Azure;
using BookStore.Infrastructure.Services.Storage.Local;
using BookStore.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            _ = services.AddScoped<IFileService, FileService>();
            _ = services.AddScoped<ITokenHandler, TokenHandler>();
            _ = services.AddHttpClient();
            _ = services.AddScoped<IApplicationService, ApplicationService>();
            _ = services.AddScoped<IObjectOperations, ObjectOperations>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            _ = serviceCollection.AddScoped<IStorage, T>();
            _ = serviceCollection.AddScoped<IStorageService, StorageService>();

        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    _ = serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    _ = serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    _ = serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}