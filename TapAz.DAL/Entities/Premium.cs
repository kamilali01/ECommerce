using TapAz.DAL.Entities.Common;
using TapAz.DAL.Enums;

namespace TapAz.DAL.Entities
{
    public class Premium : BaseEntity
    {
        public PremiumEnum Day { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
