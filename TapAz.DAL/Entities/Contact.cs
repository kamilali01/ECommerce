using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
