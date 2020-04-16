using MAF.Geo.Domain.Model.RefMaf;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public interface IVilleService
    {
        Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(string autocomplete);
    }
}
