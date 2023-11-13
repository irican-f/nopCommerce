﻿using System.Collections.Generic;
using System.Linq;
using Nop.Data;
using Nop.Core.Domain.Catalog;
using System.Threading.Tasks;
using Nop.Plugin.Misc.ApiRest.DataStructures;
using Nop.Plugin.Misc.ApiRest.Infrastructure;

namespace Nop.Plugin.Misc.ApiRest.Services
{
    public class ProductAttributesApiService : IProductAttributesApiService
    {
        private readonly IRepository<ProductAttribute> _productAttributesRepository;

        public ProductAttributesApiService(IRepository<ProductAttribute> productAttributesRepository)
        {
            _productAttributesRepository = productAttributesRepository;
        }

        public IList<ProductAttribute> GetProductAttributes(
            int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue, int sinceId = Constants.Configurations.DefaultSinceId)
        {
            var query = GetProductAttributesQuery(sinceId);

            return new ApiList<ProductAttribute>(query, page - 1, limit);
        }

        public int GetProductAttributesCount()
        {
            return GetProductAttributesQuery().Count();
        }

        Task<ProductAttribute> IProductAttributesApiService.GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            return _productAttributesRepository.GetByIdAsync(id);
        }

        private IQueryable<ProductAttribute> GetProductAttributesQuery(int sinceId = Constants.Configurations.DefaultSinceId)
        {
            var query = _productAttributesRepository.Table;

            if (sinceId > 0)
            {
                query = query.Where(productAttribute => productAttribute.Id > sinceId);
            }

            query = query.OrderBy(productAttribute => productAttribute.Id);

            return query;
        }
    }
}
