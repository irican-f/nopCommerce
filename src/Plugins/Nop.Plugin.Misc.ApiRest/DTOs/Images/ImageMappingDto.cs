using Newtonsoft.Json;
using Nop.Plugin.Misc.ApiRest.Attributes;

namespace Nop.Plugin.Misc.ApiRest.DTO.Images
{
    [ImageValidation]
    public class ImageMappingDto : ImageDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("picture_id")]
        public int PictureId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }
}
