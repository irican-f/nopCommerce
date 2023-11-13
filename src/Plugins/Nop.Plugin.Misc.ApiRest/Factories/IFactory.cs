using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ApiRest.Factories
{
    public interface IFactory<T>
    {
        Task<T> InitializeAsync();
    }
}
