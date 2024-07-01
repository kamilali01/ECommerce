using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class PremiumAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Premium>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Adverts).WithOne(i => i.Premium).HasForeignKey(a => a.PremiumId);
    }
}
