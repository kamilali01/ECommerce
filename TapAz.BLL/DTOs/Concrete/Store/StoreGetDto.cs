namespace TapAz.BLL.DTOs.Concrete.Store;

public class StoreGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PicPath { get; set; }
    public string Title { get; set; }
    public List<ContactGetDto> Contacts { get; set; }
    public List<AdvertGetDto>? Adverts { get; set; }
    public string WorkDays { get; set; }
    public TimeSpan Open { get; set; }
    public TimeSpan Close { get; set; }
}