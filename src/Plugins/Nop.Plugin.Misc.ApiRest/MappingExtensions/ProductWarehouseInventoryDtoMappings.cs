using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.ProductWarehouseIventories;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ProductWarehouseInventoryDtoMappings
    {
        public static ProductWarehouseInventoryDto ToDto(this ProductWarehouseInventory mapping)
        {
            return mapping.MapTo<ProductWarehouseInventory, ProductWarehouseInventoryDto>();
        }
    }
}
