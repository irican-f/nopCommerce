using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Products;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ProductAttributeCombinationDtoMappings
    {
        public static ProductAttributeCombinationDto ToDto(this ProductAttributeCombination productAttributeCombination)
        {
            return productAttributeCombination.MapTo<ProductAttributeCombination, ProductAttributeCombinationDto>();
        }
    }
}
