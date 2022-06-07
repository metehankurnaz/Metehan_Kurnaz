using Microsoft.EntityFrameworkCore;
using OgrenciProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Concrete
{
    public class OgrenciProjesiDbContext : DbContext
    {
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=OgrenciProjesiAksam");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrenciDers>()
                .HasKey(od => new { od.DersId, od.OgrenciId });
        }
    }
}
