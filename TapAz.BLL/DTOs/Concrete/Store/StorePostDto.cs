namespace TapAz.BLL.DTOs.Concrete.Store;

public class StorePostDto : IDto
{
    public string Name { get; set; }
    public IFormFile PicPath { get; set; }
    public string Title { get; set; }
    public string WorkDays { get; set; }
    public TimeSpan Open { get; set; }
    public TimeSpan Close { get; set; }
}
