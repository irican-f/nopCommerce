using Nop.Core.Domain.Stores;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Stores;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class StoreDtoMappings
    {
        public static StoreDto ToDto(this Store store)
        {
            return store.MapTo<Store, StoreDto>();
        }
    }
}
