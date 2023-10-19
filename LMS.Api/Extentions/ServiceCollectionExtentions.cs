using LMS.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LMS.Api.Extentions;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer");

        
        //services.AddSwaggerService();

        services.AddDbContextPool<AppDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        return services;
    }
}
