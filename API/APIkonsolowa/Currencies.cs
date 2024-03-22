using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //ewentualne przeciążenie do wpisania początkowych rekordów OnModelCreating
    }
}
