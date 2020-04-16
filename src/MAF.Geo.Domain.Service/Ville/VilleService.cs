using MAF.Geo.Domain.Model.RefMaf;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public class VilleService : IVilleService
    {
        private readonly IVilleRepository _villeRepository;

        public VilleService(IVilleRepository villeRepository)
        {
            _villeRepository = villeRepository;
        }
        public async Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(int paysId, string autocomplete)
        {
            return new ReadOnlyCollection<Ville>(await _villeRepository.GetVillesByAutocomplete(paysId, autocomplete));
        }
    }
}
