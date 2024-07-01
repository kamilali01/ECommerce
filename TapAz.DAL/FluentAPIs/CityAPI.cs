using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class CityAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<City>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Adverts).WithOne(i => i.City).HasForeignKey(a => a.City);
    }
}
