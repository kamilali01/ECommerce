namespace TapAz.BLL.DTOs.Concrete.AdvertQuestion;

public class AdvertQuestionPostDto : IDto
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public int AdvertId { get; set; }
}
