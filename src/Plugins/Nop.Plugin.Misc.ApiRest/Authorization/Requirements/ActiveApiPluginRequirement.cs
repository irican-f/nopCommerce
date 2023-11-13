using Microsoft.AspNetCore.Authorization;
using Nop.Core.Infrastructure;
using Nop.Plugin.Misc.ApiRest.Domain;

namespace Nop.Plugin.Misc.ApiRest.Authorization.Requirements
{
    public class ActiveApiPluginRequirement : IAuthorizationRequirement
    {
        public bool IsActive()
        {
            var settings = EngineContext.Current.Resolve<ApiSettings>();

            if (settings.EnableApi)
            {
                return true;
            }

            return false;
        }
    }
}
