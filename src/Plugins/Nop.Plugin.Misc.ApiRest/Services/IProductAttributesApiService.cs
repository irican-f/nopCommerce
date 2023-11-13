using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Misc.ApiRest.Infrastructure;

namespace Nop.Plugin.Misc.ApiRest.Services
{
    public interface IProductAttributesApiService
    {
        IList<ProductAttribute> GetProductAttributes(
            int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue, int sinceId = Constants.Configurations.DefaultSinceId);

        int GetProductAttributesCount();

        Task<ProductAttribute> GetByIdAsync(int id);
    }
}
