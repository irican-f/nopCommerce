using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.SpecificationAttributesParameters
{
    // JsonProperty is used only for swagger
    [ModelBinder(typeof(ParametersModelBinder<SpecificationAttributesCountParametersModel>))]
    public class SpecificationAttributesCountParametersModel
    {
    }
}
