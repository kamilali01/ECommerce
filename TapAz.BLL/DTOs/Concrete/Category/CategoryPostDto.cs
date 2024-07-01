namespace TapAz.BLL.DTOs.Concrete.Category;

public class CategoryPostDto : IDto
{
    public string Name { get; set; }
    public int? ParentId { get; set; }
}
