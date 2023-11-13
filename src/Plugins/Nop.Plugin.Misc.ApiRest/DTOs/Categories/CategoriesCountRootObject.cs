using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.Categories
{
    public class CategoriesCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
