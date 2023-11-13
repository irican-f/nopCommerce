using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Nop.Plugin.Misc.ApiRest.Authorization.Requirements;

namespace Nop.Plugin.Misc.ApiRest.Authorization.Policies
{
    public class ActiveApiPluginAuthorizationPolicy : AuthorizationHandler<ActiveApiPluginRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ActiveApiPluginRequirement requirement)
        {
            if (requirement.IsActive())
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
