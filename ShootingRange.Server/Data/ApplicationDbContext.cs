using Microsoft.EntityFrameworkCore;
using ShootingRange.Core.DomainModels;

namespace ShootingRange.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts {get; set;}
        public DbSet<Uzytkownik> Uzytkownicy {get; set;}
        public DbSet<Oferta> Oferty {get; set;}
        public DbSet<Samochod> Samochody {get; set;}
        public DbSet<Lokalizacja> Lokalizacje {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Uzytkownik>().ToTable("Uzytkownik");
            modelBuilder.Entity<Oferta>().ToTable("Oferta");
            modelBuilder.Entity<Samochod>().ToTable("Samochod");
            modelBuilder.Entity<Lokalizacja>().ToTable("Lokalizacja");
        }
    }
}