using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class StoreAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Store>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Contacts).WithOne(i => i.Store).HasForeignKey(a => a.StoreId);
        entity.HasMany(i => i.Adverts).WithOne(i => i.Store).HasForeignKey(a => a.StoreId);
    }
}
