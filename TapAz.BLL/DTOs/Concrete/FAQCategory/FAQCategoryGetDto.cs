namespace TapAz.BLL.DTOs.Concrete.FAQCategory;

public class FAQCategoriesGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

	//Relations
	public List<FAQGetDto> FAQs { get; set; }
}