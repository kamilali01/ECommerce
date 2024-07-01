namespace TapAz.BLL.DTOs.Concrete.AdvertQuestion;

public class AdvertQuestionUpdateDto : IDto
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public int AdvertId { get; set; }
}