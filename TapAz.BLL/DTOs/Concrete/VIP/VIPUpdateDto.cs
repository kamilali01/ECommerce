namespace TapAz.BLL.DTOs.Concrete.VIP;

public class VIPUpdateDto : IDto
{
    public int Id { get; set; }
    public VipEnum Day { get; set; }
}
