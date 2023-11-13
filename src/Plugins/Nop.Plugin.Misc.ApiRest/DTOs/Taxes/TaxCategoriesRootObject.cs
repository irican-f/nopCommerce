using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.DTOs.Taxes
{
    public class TaxCategoriesRootObject : ISerializableObject
    {
        public TaxCategoriesRootObject()
        {
            Taxes = new List<TaxCategoryDto>();
        }

        [JsonProperty("tax_categories")]
        public IList<TaxCategoryDto> Taxes { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "tax_categories";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(TaxCategoryDto);
        }

    }

}
