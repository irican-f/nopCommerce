using Nop.Core.Domain.Orders;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.ShoppingCarts;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ShoppingCartItemDtoMappings
    {
        public static ShoppingCartItemDto ToDto(this ShoppingCartItem shoppingCartItem)
        {
            return shoppingCartItem.MapTo<ShoppingCartItem, ShoppingCartItemDto>();
        }
    }
}
