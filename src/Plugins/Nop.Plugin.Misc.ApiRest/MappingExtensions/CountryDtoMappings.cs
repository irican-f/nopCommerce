using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.Directory;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
	public static class CountryDtoMappings
	{
        public static CountryDto ToDto(this Country address)
        {
            return address.MapTo<Country, CountryDto>();
        }

        public static Country ToEntity(this CountryDto addressDto)
        {
            return addressDto.MapTo<CountryDto, Country>();
        }
    }
}
