using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.SpecificationAttributes
{
    public class ProductSpecificationAttributesCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
