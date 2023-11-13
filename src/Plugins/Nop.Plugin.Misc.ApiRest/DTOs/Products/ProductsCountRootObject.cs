using System;
using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.Products
{
    public class ProductsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }

    }
}
