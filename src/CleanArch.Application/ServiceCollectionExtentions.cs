using CleanArch.Application.Base;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Application;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddApplicatioinServices(this IServiceCollection services)
    {
        services.AddScoped<IPersonsService, PersonsService>();
        return services;
    }
}