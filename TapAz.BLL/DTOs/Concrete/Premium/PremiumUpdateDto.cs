namespace TapAz.BLL.DTOs.Concrete.Premium;

public class PremiumUpdateDto : IDto
{
    public int Id { get; set; }
    public PremiumEnum Day { get; set; }
}

