using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.JSON.Serializers
{
    public interface IJsonFieldsSerializer
    {
        string Serialize(ISerializableObject objectToSerialize, string fields);
    }
}
