﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutoMapper;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Messages;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Shipping;
using Nop.Core.Domain.Stores;
using Nop.Core.Domain.Tax;
using Nop.Core.Domain.Topics;
using Nop.Core.Infrastructure.Mapper;
using Nop.Plugin.Misc.ApiRest.MappingExtensions;
using Nop.Plugin.Misc.ApiRest.Areas.Admin.Models;
using Nop.Plugin.Misc.ApiRest.Domain;
using Nop.Plugin.Misc.ApiRest.DTO;
using Nop.Plugin.Misc.ApiRest.DTO.Categories;
using Nop.Plugin.Misc.ApiRest.DTO.CustomerRoles;
using Nop.Plugin.Misc.ApiRest.DTO.Customers;
using Nop.Plugin.Misc.ApiRest.DTO.Languages;
using Nop.Plugin.Misc.ApiRest.DTO.Manufacturers;
using Nop.Plugin.Misc.ApiRest.DTO.NewsLetterSubscriptions;
using Nop.Plugin.Misc.ApiRest.DTO.OrderItems;
using Nop.Plugin.Misc.ApiRest.DTO.Orders;
using Nop.Plugin.Misc.ApiRest.DTO.ProductAttributes;
using Nop.Plugin.Misc.ApiRest.DTO.ProductCategoryMappings;
using Nop.Plugin.Misc.ApiRest.DTO.ProductManufacturerMappings;
using Nop.Plugin.Misc.ApiRest.DTO.Products;
using Nop.Plugin.Misc.ApiRest.DTO.ProductWarehouseIventories;
using Nop.Plugin.Misc.ApiRest.DTO.ShoppingCarts;
using Nop.Plugin.Misc.ApiRest.DTO.SpecificationAttributes;
using Nop.Plugin.Misc.ApiRest.DTO.Stores;
using Nop.Plugin.Misc.ApiRest.DTO.Warehouses;
using Nop.Plugin.Misc.ApiRest.DTOs.StateProvinces;
using Nop.Plugin.Misc.ApiRest.DTOs.Taxes;
using Nop.Plugin.Misc.ApiRest.DTOs.Topics;

namespace Nop.Plugin.Misc.ApiRest.AutoMapper
{
    public class ApiMapperConfiguration : Profile, IOrderedMapperProfile
    {
        public ApiMapperConfiguration()
        {
            CreateMap<ApiSettings, ConfigurationModel>();
            CreateMap<ConfigurationModel, ApiSettings>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Store, StoreDto>();

            CreateMap<ProductCategory, ProductCategoryMappingDto>();

            CreateMap<ProductManufacturer, ProductManufacturerMappingsDto>();
            CreateMap<ProductWarehouseInventory, ProductWarehouseInventoryDto>();

            CreateMap<Warehouse, WarehouseDto>();
            CreateMap<WarehouseDto, Warehouse>();

            CreateMap<Language, LanguageDto>();

            CreateMap<CustomerRole, CustomerRoleDto>();

            CreateMap<Manufacturer, ManufacturerDto>();

            CreateClientToClientApiModelMap();

            CreateAddressMap();
            CreateAddressDtoToEntityMap();
            CreateShoppingCartItemMap();

            CreateCustomerToDTOMap();

            CreateMap<OrderItem, OrderItemDto>();
            CreateOrderEntityToOrderDtoMap();

            CreateProductMap();

            CreateMap<ProductAttributeValue, ProductAttributeValueDto>();

            CreateMap<ProductAttribute, ProductAttributeDto>();

            CreateMap<ProductSpecificationAttribute, ProductSpecificationAttributeDto>();
            CreateMap<ProductAttributeCombination, ProductAttributeCombinationDto>();

            CreateMap<SpecificationAttribute, SpecificationAttributeDto>();
            CreateMap<SpecificationAttributeOption, SpecificationAttributeOptionDto>();

            CreateMap<NewsLetterSubscriptionDto, NewsLetterSubscription>();
            CreateMap<NewsLetterSubscription, NewsLetterSubscriptionDto>();

            CreateMap<Topic, TopicDto>();

            CreateMap<StateProvince, StateProvinceDto>();

            CreateMap<Country, CountryDto>();

            CreateMap<Currency, CurrencyDto>();

            CreateMap<TaxCategory, TaxCategoryDto>();
        }

        public int Order => 0;

        private new static void CreateMap<TSource, TDestination>()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<TSource, TDestination>()
                                      .IgnoreAllNonExisting();
        }

        private static void CreateClientToClientApiModelMap()
        {
            //AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Client, ClientApiModel>()
            //    .ForMember(x => x.ClientSecret, y => y.MapFrom(src => src.ClientSecrets.FirstOrDefault().Description))
            //    .ForMember(x => x.RedirectUrl, y => y.MapFrom(src => src.RedirectUris.FirstOrDefault().RedirectUri))
            //    .ForMember(x => x.AccessTokenLifetime, y => y.MapFrom(src => src.AccessTokenLifetime))
            //    .ForMember(x => x.RefreshTokenLifetime, y => y.MapFrom(src => src.AbsoluteRefreshTokenLifetime));
        }

        private void CreateOrderEntityToOrderDtoMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Order, OrderDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
            //.ForMember(x => x.OrderItems, y => y.MapFrom(src => src.OrderItems.Select(x => x.ToDto())));
        }

        private void CreateAddressMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Address, AddressDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
            //.ForMember(x => x.CountryName,
            //           y => y.MapFrom(src => src.Country.GetWithDefault(x => x, new Country()).Name))
            //.ForMember(x => x.StateProvinceName,
            //           y => y.MapFrom(src => src.StateProvince.GetWithDefault(x => x, new StateProvince()).Name));
        }

        private void CreateAddressDtoToEntityMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<AddressDto, Address>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
        }

        private void CreateCustomerToDTOMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Customer, CustomerDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
            //.ForMember(x => x.BillingAddress,
            //           y => y.MapFrom(src => src.BillingAddress.GetWithDefault(x => x, new Address()).ToDto()))
            //.ForMember(x => x.ShippingAddress,
            //           y => y.MapFrom(src => src.ShippingAddress.GetWithDefault(x => x, new Address()).ToDto()))
            //.ForMember(x => x.Addresses,
            //           y =>
            //               y.MapFrom(
            //                         src =>
            //                             src.Addresses.GetWithDefault(x => x, new List<Address>())
            //                                .Select(address => address.ToDto())))
            //.ForMember(x => x.ShoppingCartItems,
            //           y =>
            //               y.MapFrom(
            //                         src =>
            //                             src.ShoppingCartItems.GetWithDefault(x => x, new List<ShoppingCartItem>())
            //                                .Select(item => item.ToDto())))
            //.ForMember(x => x.RoleIds, y => y.MapFrom(src => src.CustomerRoles.Select(z => z.Id)));
        }

        private void CreateShoppingCartItemMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<ShoppingCartItem, ShoppingCartItemDto>()
                                      .IgnoreAllNonExisting();
            //.ForMember(x => x.CustomerDto,
            //           y => y.MapFrom(src =>
            //                              src.Customer.GetWithDefault(x => x, new Customer()).ToCustomerForShoppingCartItemDto()))
            //.ForMember(x => x.ProductDto,
            //           y => y.MapFrom(src => src.Product.GetWithDefault(x => x, new Product()).ToDto()));
        }

        private void CreateProductMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Product, ProductDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(p => p.RequiredProductIds, o => o.Ignore());
            //.ForMember(x => x.FullDescription, y => y.MapFrom(src => WebUtility.HtmlEncode(src.FullDescription)))
            //.ForMember(x => x.Tags,
            //           y => y.MapFrom(src => src.ProductProductTagMappings.Select(x => x.ProductTag.Name)));
        }
    }
}
