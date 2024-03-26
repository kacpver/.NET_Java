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
        public DbSet<Data> data {  get; set; }
        public DbSet<Rates> Rates { get; set; }
        public Currencies() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = DBcurr.db");
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
