using TapAz.DAL.Entities.Common;
using TapAz.DAL.Enums;

namespace TapAz.DAL.Entities
{
    public class VIP : BaseEntity
    {
        public VipEnum Day { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
