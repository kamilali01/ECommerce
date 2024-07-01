namespace TapAz.BLL.DTOs.Concrete.Advert;

public class AdvertGetDto : IDto
{
    public int Id { get; set; }
    public CategoryGetDto Category { get; set; }
    public CityGetDto City { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string PhotoPath { get; set; }
    public UserGetDto? User { get; set; }
    public StoreGetDto? Store { get; set; }
    public VIPGetDto Vip { get; set; }
    public PremiumGetDto Premium { get; set; }
    public int ViewCount { get; set; }
    public List<AdvertQuestionGetDto> Questions { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdate { get; set; }
}