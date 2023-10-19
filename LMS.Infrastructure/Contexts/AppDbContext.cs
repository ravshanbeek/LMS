using LMS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Reflection;

namespace LMS.Infrastructure.Contexts;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());
    }
}
