using MAF.Geo.Domain.Model.RefMaf;
using MAF.Geo.Domain.Service;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Repository
{
    public class VilleRepository : IVilleRepository
    {
        GeoDbContext _context;
        public VilleRepository(GeoDbContext context)
        {
            _context = context;
        }

        public Task<Ville[]> GetVillesByAutocomplete(int paysId, string autocomplete)
        {
            return _context.Villes.Where(ville => ville.PaysId == paysId && EF.Functions.Like(ville.NomVille, $"{ autocomplete}%")).ToArrayAsync();
        }
    }
}
