using System.Collections.Generic;
using Nop.Core.Domain.Shipping;

namespace Nop.Plugin.Misc.ApiRest.Services;

public interface IWarehouseApiService
{
    IList<Warehouse> GetWarehouses(IList<int> ids = null, int? productId = null);

    Warehouse GetWarehouseById(int id);
}