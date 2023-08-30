using FurnitureApp.Context;
using FurnitureApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureApp.Services;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<FakeDbContext>(opt=>opt.UseInMemoryDatabase("FurnitureDb"));
        services.AddTransient<IChairRepository, ChairRepository>();
    }
}