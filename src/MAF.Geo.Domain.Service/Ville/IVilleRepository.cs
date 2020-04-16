using MAF.Geo.Domain.Model.RefMaf;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public interface IVilleRepository
    {
        Task<Ville[]> GetVillesByAutocomplete(int paysId, string autocomplete);
    }
}
