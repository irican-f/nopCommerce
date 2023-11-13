using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.ProductCategoryMappings;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ProductCategoryMappingDtoMappings
    {
        public static ProductCategoryMappingDto ToDto(this ProductCategory mapping)
        {
            return mapping.MapTo<ProductCategory, ProductCategoryMappingDto>();
        }
    }
}
