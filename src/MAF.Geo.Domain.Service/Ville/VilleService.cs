using MAF.Geo.Domain.Model.RefMaf;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public class VilleService : IVilleService
    {
        public Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(string autocomplete)
        {
            var result = new List<Ville>
            {
                new Ville{VilleId = 1},
                new Ville{VilleId = 2},
                new Ville{VilleId = 3},
                new Ville{VilleId = 4},
            };

            return Task.FromResult(result.AsReadOnly());
        }
    }
}
