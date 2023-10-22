using LMS.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LMS.Api.Extentions;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextPool<AppDbContext>(options =>
        {
            //options.UseSqlite(configuration.GetConnectionString("SqlLite"));
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        return services;
    }
}
