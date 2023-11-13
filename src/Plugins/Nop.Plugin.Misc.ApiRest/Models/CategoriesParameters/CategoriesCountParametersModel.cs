using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.CategoriesParameters
{
    [ModelBinder(typeof(ParametersModelBinder<CategoriesCountParametersModel>))]
    public class CategoriesCountParametersModel : BaseCategoriesParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
