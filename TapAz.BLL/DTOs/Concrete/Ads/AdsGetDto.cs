namespace TapAz.BLL.DTOs.Concrete.Ads;

public class AdsGetDto : IDto
{
    public int Id { get; set; }
    public string PicPath { get; set; }
    public string Link { get; set; }
}