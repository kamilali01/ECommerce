namespace TapAz.BLL.DTOs.Concrete.VIP;

public class VIPGetDto : IDto
{
    public int Id { get; set; }
    public VipEnum Day { get; set; }
}