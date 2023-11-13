using Nop.Core.Domain.Tax;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTOs.Taxes;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class TaxCategoryDtoMappings
    {
        public static TaxCategoryDto ToDto(this TaxCategory taxCategory)
        {
            return taxCategory.MapTo<TaxCategory, TaxCategoryDto>();
        }
    }
}
