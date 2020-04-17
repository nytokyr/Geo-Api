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

        public Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(QueryVille query) =>
             _villeRepository.GetVillesByAutocomplete(query!.PaysId, query.AutoComplete);

        public Task<ReadOnlyCollection<Ville>> SearchVille(QueryVille query)
        {
            if (!string.IsNullOrEmpty(query.CodeInsee))
                return _villeRepository.SearchVilleByCodeInsee(query);
            if (!string.IsNullOrEmpty(query.CodePostal))
                return _villeRepository.SearchVilleBycodePostal(query);

            return Task.FromResult(new ReadOnlyCollection<Ville>(new List<Ville>()));
        }
    }
}
