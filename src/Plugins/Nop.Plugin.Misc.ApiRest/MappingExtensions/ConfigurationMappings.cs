using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.Areas.Admin.Models;
using Nop.Plugin.Misc.ApiRest.Domain;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class ConfigurationMappings
    {
        public static ConfigurationModel ToModel(this ApiSettings apiSettings)
        {
            return apiSettings.MapTo<ApiSettings, ConfigurationModel>();
        }

        public static ApiSettings ToEntity(this ConfigurationModel apiSettingsModel)
        {
            return apiSettingsModel.MapTo<ConfigurationModel, ApiSettings>();
        }
    }
}
