using DostavaHrane.Entiteti;
using Microsoft.EntityFrameworkCore;

namespace DostavaHrane.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Musterija> Musterije { get; set; }
        public DbSet<Narudzbina> Narudzbine { get; set; }
        public DbSet<Restoran> Restorani { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    

            modelBuilder.Entity<Narudzbina>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(s => s.Restoran)
                    .WithMany(u => u.Narudzbine)
                    .HasForeignKey(s => s.RestoranId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(s => s.Dostavljac)
                    .WithMany(u => u.Narudzbine)
                    .HasForeignKey(s => s.DostavljacId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(s => s.Adresa)
                    .WithMany(u => u.Narudzbine)
                    .HasForeignKey(s => s.AdresaId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(s => s.Musterija)
                    .WithMany(u => u.Narudzbine)
                    .HasForeignKey(s => s.MusterijaId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.StavkeNarudzbine)
                    .WithOne(e => e.Narudzbina)
                    .HasForeignKey(e => e.NarudzbinaId);
            });

            modelBuilder.Entity <Adresa>(entity =>
            {
                entity.HasOne(s => s.Musterija)
                    .WithMany(u => u.Adrese)
                    .HasForeignKey(s => s.MusterijaId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }

    }



}

