using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            _ = services.AddMediatR(Assembly.GetExecutingAssembly());
            _ = services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}