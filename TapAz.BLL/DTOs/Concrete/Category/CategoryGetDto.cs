namespace TapAz.BLL.DTOs.Concrete.Category;

public class CategoryGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryGetDto? Parent { get; set; }
    public List<ParameterGetDto> Parameters { get; set; }
}