using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.ProductManufacturerMappings;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ProductManufacturerMappingDtoMappings
    {
        public static ProductManufacturerMappingsDto ToDto(this ProductManufacturer mapping)
        {
            return mapping.MapTo<ProductManufacturer, ProductManufacturerMappingsDto>();
        }
    }
}
