using Brother.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Brother.Application;

public static class ApplicationRegistration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBreadcrumbService, BreadcrumbService>();
        return services;
    }
}
