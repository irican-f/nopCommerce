using Nop.Core.Domain.Orders;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Orders;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class OrderDtoMappings
    {
        public static OrderDto ToDto(this Order order)
        {
            return order.MapTo<Order, OrderDto>();
        }
    }
}
