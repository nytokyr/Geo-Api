using MAF.Geo.Domain.Model.RefMaf;
using Microsoft.EntityFrameworkCore;

namespace MAF.Geo.Repository
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Ville> Villes { get; set; }
        public DbSet<RegionAdministrative> RegionAdministratives { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Pays> Pays { get; set; }
    }
}
