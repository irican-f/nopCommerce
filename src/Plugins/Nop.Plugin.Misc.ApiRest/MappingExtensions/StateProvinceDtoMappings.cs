using Nop.Core.Domain.Directory;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO;
using Nop.Plugin.Misc.ApiRest.DTOs.StateProvinces;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class StateProvinceDtoMappings
    {
        public static StateProvinceDto ToDto(this StateProvince address)
        {
            return address.MapTo<StateProvince, StateProvinceDto>();
        }

        public static StateProvince ToEntity(this StateProvinceDto address)
        {
            return address.MapTo<StateProvinceDto, StateProvince>();
        }
    }
}
