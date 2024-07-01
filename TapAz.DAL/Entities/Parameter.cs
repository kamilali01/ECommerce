using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class Parameter : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Category> Categories { get; set; }
    }
}
