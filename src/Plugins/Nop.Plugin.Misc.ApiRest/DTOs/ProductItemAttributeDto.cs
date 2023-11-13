using Newtonsoft.Json;
using Nop.Plugin.Misc.ApiRest.DTO.Base;

namespace Nop.Plugin.Misc.ApiRest.DTO
{
    [JsonObject(Title = "attribute")]
    public class ProductItemAttributeDto : BaseDto
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
