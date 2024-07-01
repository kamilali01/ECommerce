namespace TapAz.BLL.DTOs.Concrete.AdvertQuestion;

public class AdvertQuestionGetDto : IDto
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public AdvertGetDto Advert { get; set; }
}
