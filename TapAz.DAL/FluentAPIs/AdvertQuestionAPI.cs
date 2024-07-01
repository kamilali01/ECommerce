using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class AdvertQuestionAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<AdvertQuestion>();

        entity.HasKey(a => a.Id);
        entity.HasOne(i => i.Advert).WithMany(i => i.Questions).HasForeignKey(a => a.AdvertId);
    }
}