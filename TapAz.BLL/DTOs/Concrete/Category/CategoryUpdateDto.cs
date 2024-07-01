namespace TapAz.BLL.DTOs.Concrete.Category;

public class CategoryUpdateDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
}
