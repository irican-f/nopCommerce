﻿using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.ProductManufacturerMappings
{
    public class ProductManufacturerMappingsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
