using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class FAQ : BaseEntity
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<FAQCategories> Categories { get; set; }
    }
}
