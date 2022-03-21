using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ServiceBilletterie.Models
{
    public class eventContext : DbContext
    {
        public eventContext()
        {
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.AddRange(
                new Evenements()
                {
                    CategorieEvent = "Concert",
                    DateDebutEvent = new DateTime(2022,03,29,17,00,00),
                    DateFinEvent = new DateTime(2022, 03, 29, 22, 00, 00),
                    LieuEvent = "Paris",
                    NbTickets = 200,
                    Organisateur = "Good Music Prod.",
                    NomEvent = "Taylor The Creator"
                }
                );
            this.SaveChanges();
        }

        public eventContext(DbContextOptions<eventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Billetterie> Billetterie { get; set; }
        public virtual DbSet<Evenements> Evenements { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=matt;password=loki;database=event", x => x.ServerVersion("10.7.3-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billetterie>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("billetterie");

                entity.Property(e => e.IdBillet)
                    .HasColumnName("idBillet")
                    .HasColumnType("smallint(6)");
                  

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.HasOne(d => d.IdBilletNavigation)
                    .WithOne(p => p.Billetterie)
                    .HasForeignKey<Billetterie>(d => d.IdBillet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("billetterie_FK");
            });

            modelBuilder.Entity<Evenements>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PRIMARY");

                entity.ToTable("evenements");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("idEvent")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CategorieEvent)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DateDebutEvent)
                    .HasColumnName("dateDebutEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinEvent)
                    .HasColumnName("dateFinEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.LieuEvent)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.NbTickets)
                    .HasColumnName("nbTickets")
                    .HasColumnType("bigint(200)")
                    .HasDefaultValueSql("'250'");

                entity.Property(e => e.NomEvent)
                    .IsRequired()
                    .HasColumnName("nomEvent")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Organisateur)
                    .IsRequired()
                    .HasColumnName("organisateur")
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

           


        }


    }
}
