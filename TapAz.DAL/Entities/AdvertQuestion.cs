using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class AdvertQuestion : BaseEntity
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int AdvertId { get; set; }
        public Advert Advert { get; set; }
    }
}
