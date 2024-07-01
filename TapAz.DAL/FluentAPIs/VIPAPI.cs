using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class VIPAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<VIP>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Adverts).WithOne(i => i.Vip).HasForeignKey(a => a.PremiumId);
    }
}
