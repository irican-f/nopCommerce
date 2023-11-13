using Nop.Core.Domain.Messages;
using Nop.Plugin.Misc.ApiRest.AutoMapper;
using Nop.Plugin.Misc.ApiRest.DTO.NewsLetterSubscriptions;

namespace Nop.Plugin.Misc.ApiRest.MappingExtensions
{
    public static class NewsLetterSubscriptoonDtoMappings
    {
        public static NewsLetterSubscriptionDto ToDto(this NewsLetterSubscription newsLetterSubscription)
        {
            return newsLetterSubscription.MapTo<NewsLetterSubscription, NewsLetterSubscriptionDto>();
        }

        public static NewsLetterSubscription ToEntity(this NewsLetterSubscriptionDto newsLetterSubscriptionDto)
        {
            return newsLetterSubscriptionDto.MapTo<NewsLetterSubscriptionDto, NewsLetterSubscription>();
        }
    }
}
