using CleanArch.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure.External;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddApplicationExternalServices(this IServiceCollection services)
    {
        services.AddScoped<ISMSAdaptor, SMSAdaptor>();
        return services;
    }
}