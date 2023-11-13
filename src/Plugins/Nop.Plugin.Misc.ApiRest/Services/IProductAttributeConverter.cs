using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.Services
{
    public interface IProductAttributeConverter
    {
        List<ProductItemAttributeDto> Parse(string attributesXml);
        Task<string> ConvertToXmlAsync(List<ProductItemAttributeDto> attributeDtos, int productId);
    }
}
