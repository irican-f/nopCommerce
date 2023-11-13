using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ApiRest.ModelBinders;

namespace Nop.Plugin.Misc.ApiRest.Models.OrdersParameters
{
    [ModelBinder(typeof(ParametersModelBinder<OrdersCountParametersModel>))]
    public class OrdersCountParametersModel : BaseOrdersParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
