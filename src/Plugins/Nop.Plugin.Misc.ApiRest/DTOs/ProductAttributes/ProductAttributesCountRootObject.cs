using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.ProductAttributes
{
    public class ProductAttributesCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
