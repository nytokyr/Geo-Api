using MAF.Geo.Domain.Model.RefMaf;
using MAF.Geo.Domain.Service;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
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

        public async Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(int paysId, string autocomplete)
        {
            var result = await _context.Villes.Where(ville => ville.PaysId == paysId
                                             && (EF.Functions.Like(ville.CodePostal, $"{ autocomplete}%")
                                                 ||
                                                 EF.Functions.Like(ville.NomVille, $"{ autocomplete}%")))
                                        .ToArrayAsync().ConfigureAwait(false);
            return new ReadOnlyCollection<Ville>(result);
        }

        public async Task<ReadOnlyCollection<Ville>> SearchVilleByCodeInsee(QueryVille query)
        {
            var result = await _context.Villes.Where(ville => ville.PaysId == query.PaysId && ville.CodeInsee == query.CodeInsee).ToListAsync().ConfigureAwait(false);
            return new ReadOnlyCollection<Ville>(result);
        }

        public async Task<ReadOnlyCollection<Ville>> SearchVilleBycodePostal(QueryVille query)
        {
            var result = await _context.Villes.Where(ville => ville.PaysId == query.PaysId && ville.CodePostal == query.CodePostal).ToListAsync().ConfigureAwait(false);
            return new ReadOnlyCollection<Ville>(result);
        }
    }
}
