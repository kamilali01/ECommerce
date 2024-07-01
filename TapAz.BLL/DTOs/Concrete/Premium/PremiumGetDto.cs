namespace TapAz.BLL.DTOs.Concrete.Premium;

public class PremiumGetDto : IDto
{
    public int Id { get; set; }
    public PremiumEnum Day { get; set; }
}