using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.ProductCategoryMappingsParameters
{
    [ModelBinder(typeof(ParametersModelBinder<ProductCategoryMappingsCountParametersModel>))]
    public class ProductCategoryMappingsCountParametersModel : BaseCategoryMappingsParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
