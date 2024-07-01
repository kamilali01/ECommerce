namespace TapAz.BLL.DTOs.Concrete.Contact;

public class ContactGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string IconPath { get; set; }
    public string Text { get; set; }
    public string Link { get; set; }
    public StoreGetDto Store { get; set; }
}