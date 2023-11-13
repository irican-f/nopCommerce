using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Http;
using Nop.Plugin.Misc.ApiRest.DTO.Categories;
using Nop.Plugin.Misc.ApiRest.Helpers;

namespace Nop.Plugin.Misc.ApiRest.Validators
{
    [UsedImplicitly]
    public class CategoryDtoValidator : BaseDtoValidator<CategoryDto>
    {
        #region Constructors

        public CategoryDtoValidator(IHttpContextAccessor httpContextAccessor, IJsonHelper jsonHelper, Dictionary<string, object> requestJsonDictionary) :
            base(httpContextAccessor, jsonHelper, requestJsonDictionary)
        {
            SetNameRule();
        }

        #endregion

        #region Private Methods

        private void SetNameRule()
        {
            SetNotNullOrEmptyCreateOrUpdateRule(c => c.Name, "invalid name", "name");
        }

        #endregion
    }
}
