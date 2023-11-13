using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Misc.ApiRest.DTO.Base;

namespace Nop.Plugin.Misc.ApiRest.DTOs.StateProvinces
{

    [JsonObject(Title = "province")]
    public class StateProvinceDto : BaseDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }
    }
    
}
