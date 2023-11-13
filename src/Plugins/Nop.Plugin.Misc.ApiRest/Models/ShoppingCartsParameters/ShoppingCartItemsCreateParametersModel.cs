using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nop.Plugin.Misc.ApiRest.ModelBinders;
using Nop.Plugin.Misc.ApiRest.DTO.ShoppingCarts;
using Nop.Plugin.Misc.ApiRest.DTOs.ShoppingCarts;

namespace Nop.Plugin.Misc.ApiRest.Models.ShoppingCartsParameters
{
    [JsonObject(Title = "parameters")]
    public class ShoppingCartItemsCreateParametersModel
	{
        [JsonProperty("customer_id", Required = Required.Always)]
        public int CustomerId { get; set; }

        /// <summary>
        ///     Gets the log type
        /// </summary>
        [JsonProperty("shopping_cart_type", Required = Required.Always)]
        public ShoppingCartType ShoppingCartType { get; set; }

        /// <summary>
        ///     A comma-separated list of shopping cart items to create
        /// </summary>
        [JsonProperty("items")]
        public List<ShoppingCartItemDto> Items { get; set; }
    }
}
