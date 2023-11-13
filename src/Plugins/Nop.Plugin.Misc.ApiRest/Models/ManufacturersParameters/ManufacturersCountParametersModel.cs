using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.ManufacturersParameters
{
    [ModelBinder(typeof(ParametersModelBinder<ManufacturersCountParametersModel>))]
    public class ManufacturersCountParametersModel : BaseManufacturersParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
