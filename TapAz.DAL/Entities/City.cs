using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
