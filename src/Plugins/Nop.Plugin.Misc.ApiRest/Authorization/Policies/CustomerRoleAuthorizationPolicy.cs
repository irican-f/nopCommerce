﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Nop.Plugin.Misc.ApiRest.Authorization.Requirements;

namespace Nop.Plugin.Misc.ApiRest.Authorization.Policies
{
    public class CustomerRoleAuthorizationPolicy : AuthorizationHandler<CustomerRoleRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerRoleRequirement requirement)
        {
            if (await requirement.IsCustomerInRoleAsync())
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
    }
}
