using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gambler.Broadcast.Application.Services;

public static class ServiceRegistration
{
    public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
    }
}
