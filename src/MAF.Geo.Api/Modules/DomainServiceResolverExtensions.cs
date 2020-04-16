using MAF.Geo.Domain.Service;
using Microsoft.Extensions.DependencyInjection;

namespace MAF.Geo.Api.Modules
{
    public static class DomainServiceResolverExtensions
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {
            services.AddScoped<IVilleService, VilleService>();

            return services;
        }
    }
}
