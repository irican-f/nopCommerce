using Nop.Core.Domain.Shipping;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Warehouses;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class WarehouseDtoMappings
    {
        public static WarehouseDto ToDto(this Warehouse warehouse)
        {
            return warehouse.MapTo<Warehouse, WarehouseDto>();
        }
    }
}
