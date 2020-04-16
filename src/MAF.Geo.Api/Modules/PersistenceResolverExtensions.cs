using MAF.Geo.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MAF.Geo.Domain.Service;

namespace MAF.Geo.Api.Modules
{
    public static class PersistenceResolverExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddScoped<IVilleRepository, VilleRepository>()
                .AddDbContext<GeoDbContext>(
                 options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
