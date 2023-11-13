using Nop.Core.Domain.Customers;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.Customers;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class CustomerDtoMappings
    {
        public static CustomerDto ToDto(this Customer customer)
        {
            return customer.MapTo<Customer, CustomerDto>();
        }
    }
}
