using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Entities
{
    public class Advert : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PhotoPath { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? StoreId { get; set; }
        public Store? Store { get; set; }
        public VIP? Vip { get; set; }
        public int? VipId { get; set; }
        public Premium? Premium { get; set; }
        public int? PremiumId { get; set; }
        public int ViewCount { get; set; }
        public List<AdvertQuestion> Questions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
