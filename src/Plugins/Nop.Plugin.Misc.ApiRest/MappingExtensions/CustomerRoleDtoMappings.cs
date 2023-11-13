using Nop.Core.Domain.Customers;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.CustomerRoles;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class CustomerRoleDtoMappings
    {
        public static CustomerRoleDto ToDto(this CustomerRole customerRole)
        {
            return customerRole.MapTo<CustomerRole, CustomerRoleDto>();
        }
    }
}
