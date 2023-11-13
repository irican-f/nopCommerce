﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.DTO
{
    public class CurrenciesRootObject : ISerializableObject
    {
        public CurrenciesRootObject()
        {
            Currencies = new List<CurrencyDto>();
        }

        [JsonProperty("currencies")]
        public IList<CurrencyDto> Currencies { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "currencies";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(CurrencyDto);
        }
    }
}
