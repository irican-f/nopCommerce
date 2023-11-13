using System;

namespace Nop.Plugin.Misc.ApiRest.DTO
{
    public interface ISerializableObject
    {
        string GetPrimaryPropertyName();
        Type GetPrimaryPropertyType();
    }
}
