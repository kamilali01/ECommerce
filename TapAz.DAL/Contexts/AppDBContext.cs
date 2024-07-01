using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapAz.DAL.Entities;
using TapAz.DAL.FluentAPIs;

namespace TapAz.DAL.Contexts
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertQuestion> AdvertQuestions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<FAQCategories> FAQCategories { get; set; }
        public DbSet<MoneyToWallet> MoneyToWallets { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<VIP> VIPs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Ads>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Store>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<AdvertQuestion>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Parameter>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Contact>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<FAQCategories>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<FAQ>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<MoneyToWallet>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Premium>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<VIP>().HasQueryFilter(m => !m.IsDeleted);

            AdvertAPI.Fluent(modelBuilder);
        }

    }
}
