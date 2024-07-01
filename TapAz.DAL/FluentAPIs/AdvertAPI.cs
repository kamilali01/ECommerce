using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class AdvertAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Advert>();

        entity.HasKey(a => a.Id);
        entity.HasOne(i=>i.Category).WithMany(i=>i.Adverts).HasForeignKey(a => a.CategoryId);
        entity.HasOne(i => i.User).WithMany(i => i.Adverts).HasForeignKey(a => a.UserId);
        entity.HasOne(i => i.City).WithMany(i => i.Adverts).HasForeignKey(a => a.CityId);
        entity.HasOne(i => i.Store).WithMany(i => i.Adverts).HasForeignKey(a => a.StoreId);
        entity.HasOne(i => i.Premium).WithMany(i => i.Adverts).HasForeignKey(a => a.PremiumId);
        entity.HasMany(i => i.Questions).WithOne(i => i.Advert).HasForeignKey(a => a.AdvertId);
    }
}
