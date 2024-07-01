using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class FAQCategories : BaseEntity
    {
        public string Name { get; set; }
        public List<FAQ> FAQs { get; set; }
    }
}
