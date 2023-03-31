using CleanArch.Application;
using CleanArch.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure.Persistence;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IPersonRepo, PersonRepo>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddDbContext<ApplicationDbContext>((IServiceProvider serviceProvider, DbContextOptionsBuilder options) =>
        {
            options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"));
        });
        return services;
    }
}