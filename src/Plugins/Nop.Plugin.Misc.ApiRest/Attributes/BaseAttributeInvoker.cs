using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ApiRest.Attributes
{
    public abstract class BaseValidationAttribute : Attribute
    {
        public abstract Task ValidateAsync(object instance);
        public abstract Dictionary<string, string> GetErrors();
    }
}
