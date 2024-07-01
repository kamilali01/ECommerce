namespace TapAz.BLL.DTOs.Concrete.Ads;

public class AdsUpdateDto : IDto
{
    public int Id { get; set; }
    public IFormFile PicPath { get; set; }
    public string Link { get; set; }
}