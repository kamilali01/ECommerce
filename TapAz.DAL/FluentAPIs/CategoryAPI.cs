using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class CategoryAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Category>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Adverts).WithOne(i => i.Category).HasForeignKey(a => a.CategoryId);
    }
}
