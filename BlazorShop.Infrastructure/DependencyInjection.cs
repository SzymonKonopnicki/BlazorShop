using BlazorShop.Application.Interfaces;
using BlazorShop.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorShop.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddScoped<IBlazorShopDbContext, BlazorShopDbContext>();   

        return services;
    }
}
