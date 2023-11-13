using Nop.Core.Domain.Orders;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.OrderItems;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class OrderItemDtoMappings
    {
        public static OrderItemDto ToDto(this OrderItem orderItem)
        {
            return orderItem.MapTo<OrderItem, OrderItemDto>();
        }
    }
}
