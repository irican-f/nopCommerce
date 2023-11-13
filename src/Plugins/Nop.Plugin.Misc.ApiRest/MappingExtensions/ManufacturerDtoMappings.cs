using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Manufacturers;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ManufacturerDtoMappings
    {
        public static ManufacturerDto ToDto(this Manufacturer manufacturer)
        {
            return manufacturer.MapTo<Manufacturer, ManufacturerDto>();
        }
    }
}
