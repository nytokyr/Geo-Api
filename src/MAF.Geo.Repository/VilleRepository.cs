using MAF.Geo.Domain.Service;

namespace MAF.Geo.Repository
{
    public class VilleRepository : IVilleRepository
    {
        GeoDbContext _context;
        public VilleRepository(GeoDbContext context)
        {
            _context = context;
        }
    }
}
