using Newtonsoft.Json;
using Nop.Plugin.Misc.ApiRest.DTO.Base;

namespace Nop.Plugin.Misc.ApiRest.DTO.Manufacturers
{
    [JsonObject(Title = "discount")]
    //[Validator(typeof(ProductDtoValidator))]
    public class DiscountManufacturerMappingDto : BaseDto
    {
        /// <summary>
        ///     Gets or sets the discount identifier
        /// </summary>
        [JsonProperty("discount_id")]
        public int DiscountId { get; set; }


        [JsonProperty("discount_name")]
        public string DiscountName { get; set; }
    }
}
