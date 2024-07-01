namespace TapAz.BLL.DTOs.Concrete.Parameter;

public class ParameterUpdateDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}
