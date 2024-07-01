using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public List<Parameter> Parameters { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
