using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("APIokienkowa"), InternalsVisibleTo("GUI")]

namespace APIkonsolowa
{
    internal class Currencies : DbContext
    {
        public DbSet<Data> data {  get; set; }
        public Currencies() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Currencies.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rates>().HasNoKey();

            modelBuilder.Entity<Data>()
            .HasOne(d => d.Rates)
            .WithOne()
            .HasForeignKey(r => r.DataId);
        }
    }
}
