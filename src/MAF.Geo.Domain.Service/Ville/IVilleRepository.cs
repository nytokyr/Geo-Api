using MAF.Geo.Domain.Model.RefMaf;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public interface IVilleRepository
    {
        Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(int paysId, string autocomplete);
        Task<ReadOnlyCollection<Ville>> SearchVilleByCodeInsee(QueryVille query);
        Task<ReadOnlyCollection<Ville>> SearchVilleBycodePostal(QueryVille query);
    }
}
