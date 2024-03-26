using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currencies_API
{
    internal class Currencies : DbContext
    {
        public DbSet<Data> Data {  get; set; }
        public DbSet<Rates> Rates { get; set; }
        public Currencies() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = Curr.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>()
        .HasOne(d => d.rates)
        .WithOne()
        .HasForeignKey<Rates>(r => r.Id);
        }

    
    }
}
