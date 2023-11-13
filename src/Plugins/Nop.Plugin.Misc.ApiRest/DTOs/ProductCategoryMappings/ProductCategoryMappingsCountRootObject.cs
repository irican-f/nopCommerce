using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.ProductCategoryMappings
{
    public class ProductCategoryMappingsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
