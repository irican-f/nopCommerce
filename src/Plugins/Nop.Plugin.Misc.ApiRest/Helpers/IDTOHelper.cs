using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Shipping;
using Nop.Core.Domain.Stores;
using Nop.Core.Domain.Tax;
using Nop.Core.Domain.Topics;
using Nop.Plugin.Misc.ApiRest.DTO;
using Nop.Plugin.Misc.ApiRest.DTO.Categories;
using Nop.Plugin.Misc.ApiRest.DTO.Languages;
using Nop.Plugin.Misc.ApiRest.DTO.Manufacturers;
using Nop.Plugin.Misc.ApiRest.DTO.OrderItems;
using Nop.Plugin.Misc.ApiRest.DTO.Orders;
using Nop.Plugin.Misc.ApiRest.DTO.ProductAttributes;
using Nop.Plugin.Misc.ApiRest.DTO.Products;
using Nop.Plugin.Misc.ApiRest.DTO.ShoppingCarts;
using Nop.Plugin.Misc.ApiRest.DTO.SpecificationAttributes;
using Nop.Plugin.Misc.ApiRest.DTO.Stores;
using Nop.Plugin.Misc.ApiRest.DTO.Warehouses;
using Nop.Plugin.Misc.ApiRest.DTOs.Taxes;
using Nop.Plugin.Misc.ApiRest.DTOs.Topics;

namespace Nop.Plugin.Misc.ApiRest.Helpers
{
    public interface IDTOHelper
    {
        Task<ProductDto> PrepareProductDTOAsync(Product product);
        Task<CategoryDto> PrepareCategoryDTOAsync(Category category);
        Task<OrderDto> PrepareOrderDTOAsync(Order order);
        Task<ShoppingCartItemDto> PrepareShoppingCartItemDTOAsync(ShoppingCartItem shoppingCartItem);
        Task<OrderItemDto> PrepareOrderItemDTOAsync(OrderItem orderItem);
        Task<StoreDto> PrepareStoreDTOAsync(Store store);
        Task<LanguageDto> PrepareLanguageDtoAsync(Language language);
        Task<CurrencyDto> PrepareCurrencyDtoAsync(Currency currency);
        ProductAttributeDto PrepareProductAttributeDTO(ProductAttribute productAttribute);
        ProductSpecificationAttributeDto PrepareProductSpecificationAttributeDto(ProductSpecificationAttribute productSpecificationAttribute);
        SpecificationAttributeDto PrepareSpecificationAttributeDto(SpecificationAttribute specificationAttribute);
        Task<ManufacturerDto> PrepareManufacturerDtoAsync(Manufacturer manufacturer);

        Task<WarehouseDto> PrepareWarehouseDtoAsync(Warehouse warehouse);
        TopicDto PrepareTopicDTO(Topic topic);
        TaxCategoryDto prepareTaxCategoryDto(TaxCategory taxCategory);
    }
}