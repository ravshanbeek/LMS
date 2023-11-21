using LMS.Application;
using LMS.Application.Services.Authentication;
using LMS.Infrastructure;

namespace LMS.Api.Extentions;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddServiceCollections(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddInfrastructureServices(configuration);
        services.AddApplicationServices();

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddTransient<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
