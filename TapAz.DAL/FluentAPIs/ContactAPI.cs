using Microsoft.EntityFrameworkCore;
using TapAz.DAL.Entities;

namespace TapAz.DAL.FluentAPIs;

public static class ContactAPI
{
    public static void Fluent(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Contact>();

        entity.HasKey(a => a.Id);
        entity.HasOne(i => i.Store).WithMany(i => i.Contacts).HasForeignKey(a => a.StoreId);
        entity.HasOne(i => i.User).WithMany(i => i.Contacts).HasForeignKey(a => a.UserId);
    }
}
