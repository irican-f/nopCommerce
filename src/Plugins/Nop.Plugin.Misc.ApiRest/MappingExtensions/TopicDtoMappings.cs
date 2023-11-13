using Nop.Core.Domain.Topics;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTOs.Topics;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class TopicDtoMappings
    {
        public static TopicDto ToDto(this Topic topic)
        {
            return topic.MapTo<Topic, TopicDto>();
        }
    }
}
