using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Misc.ApiRest.DTO.Orders
{
    public class OrdersRootObject : ISerializableObject
    {
        public OrdersRootObject()
        {
            Orders = new List<OrderDto>();
        }

        [JsonProperty("orders")]
        public IList<OrderDto> Orders { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "orders";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(OrderDto);
        }
    }
}
