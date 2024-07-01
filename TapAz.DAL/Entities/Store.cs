using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string PicPath { get; set; }
        public string Title { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Advert>? Adverts { get; set; }
        public string WorkDays { get; set; }
        public TimeSpan Open { get; set; }
        public TimeSpan Close { get; set; }
    }
}
