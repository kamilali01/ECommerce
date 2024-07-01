namespace TapAz.BLL.DTOs.Concrete.User;

public class UserPostDto : IDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Number { get; set; }
    public int Wallet { get; private set; } = 0;
}