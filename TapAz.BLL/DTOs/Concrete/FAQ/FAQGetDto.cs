namespace TapAz.BLL.DTOs.Concrete.FAQ;

public class FAQGetDto : IDto
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

	//Relations
	public FAQCategoriesGetDto FAQCategory { get; set; }
}