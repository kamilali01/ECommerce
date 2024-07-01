using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class UserAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<User>();

        entity.HasKey(a => a.Id);
        entity.HasMany(i => i.Contacts).WithOne(i => i.User).HasForeignKey(a => a.UserId);
        entity.HasMany(i => i.Adverts).WithOne(i => i.User).HasForeignKey(a => a.UserId);
    }
}
