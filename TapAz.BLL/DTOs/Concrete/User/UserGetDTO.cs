namespace TapAz.BLL.DTOs.Concrete.User;

public class UserGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Number { get; set; }
    public int Wallet { get; set; }
    public List<AdvertGetDto>? Selected { get; set; }
}
