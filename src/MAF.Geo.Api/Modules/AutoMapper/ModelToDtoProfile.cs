using AutoMapper;
using MAF.Geo.Api.Dto;
using MAF.Geo.Domain.Model.RefMaf;

namespace MAF.Geo.Api.Modules.AutoMapper
{
    public class ModelToDtoProfile : Profile
    {
        public ModelToDtoProfile()
        {
            CreateMap<Ville, VilleDto>();
        }
    }
}
