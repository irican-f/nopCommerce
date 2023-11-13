using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.Orders
{
    public class OrdersCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
