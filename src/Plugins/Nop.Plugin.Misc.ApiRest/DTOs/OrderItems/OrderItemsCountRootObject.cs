using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.OrderItems
{
    public class OrderItemsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
