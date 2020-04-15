using MAF.Geo.Domain.Service.Ville;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Api.Modules
{
    public static class DomainServiceResolverExtensions
    {
        public static IServiceCollection ResolveDomainService(this IServiceCollection services)
        {
            services.AddScoped<IVilleService, VilleService>();

            return services;
        }
    }
}
