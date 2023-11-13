using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.ProductManufacturerMappingsParameters
{
    [ModelBinder(typeof(ParametersModelBinder<ProductManufacturerMappingsCountParametersModel>))]
    public class ProductManufacturerMappingsCountParametersModel : BaseManufacturerMappingsParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
