namespace TapAz.BLL.DTOs.Concrete.Contact;

public class ContactUpdateDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IFormFile IconPath { get; set; }
    public string Text { get; set; }
    public string Link { get; set; }
    public int StoreId { get; set; }
}