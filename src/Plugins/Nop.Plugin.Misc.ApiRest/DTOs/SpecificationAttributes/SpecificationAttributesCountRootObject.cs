using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.SpecificationAttributes
{
    public class SpecificationAttributesCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
