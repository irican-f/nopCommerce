using Nop.Core.Domain.Catalog;

namespace Nop.Plugin.Misc.ApiRest.Services
{
    public interface IProductPictureService
    {
        ProductPicture GetProductPictureByPictureId(int pictureId);
    }
}
