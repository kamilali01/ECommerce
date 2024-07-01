namespace TapAz.BLL.DTOs.Concrete.Parameter;

public class ParameterGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public List<CategoryGetDto> Categories { get; set; }
}