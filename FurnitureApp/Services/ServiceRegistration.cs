using FurnitureApp.Context;
using FurnitureApp.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureApp.Services;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<FakeDbContext>();
        services.AddScoped<IChairRepository, ChairRepository>();
    }
}