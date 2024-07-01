namespace TapAz.BLL.DTOs.Concrete.Ads;

public class AdsPostDto : IDto
{
    public IFormFile PicPath { get; set; }
    public string Link { get; set; }
}
