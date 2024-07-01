namespace TapAz.BLL.DTOs.Concrete.Advert;

public class AdvertUpdateDto : IDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int CityId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public IFormFile PhotoPath { get; set; }
    public int? UserId { get; set; }
    public int? StoreId { get; set; }
    public int VipId { get; set; }
    public int PremiumId { get; set; }
}