using System;
using System.Collections.Generic;
using Nop.Core.Domain.Messages;
using Nop.Plugin.Misc.ApiRest.Infrastructure;

namespace Nop.Plugin.Misc.ApiRest.Services
{
    public interface INewsLetterSubscriptionApiService
    {
        List<NewsLetterSubscription> GetNewsLetterSubscriptions(
            DateTime? createdAtMin = null, DateTime? createdAtMax = null,
            int limit = Constants.Configurations.DefaultLimit, int page = Constants.Configurations.DefaultPageValue,
            int sinceId = Constants.Configurations.DefaultSinceId,
            bool? onlyActive = true);
    }
}
