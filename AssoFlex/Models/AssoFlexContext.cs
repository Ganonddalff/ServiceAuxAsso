using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;

namespace AssoFlex.Models
{
    public class AssoFlexContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<Adhesion> Adhesions { get; set; }
        public DbSet<Souscription> Souscriptions { get; set; }
        
        public DbSet<Crowdfunding> Crowdfundings { get; set; }
        
        public DbSet<Contrepartie> Contreparties { get; set; }
        
        public DbSet<Contribution> Contributions { get; set; }
        
        public DbSet<Billetterie> Billetteries { get; set; }
        
        public DbSet<Evenement> Evenements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
                optionsBuilder.UseMySql("server=localhost;user id=matt;password=loki;database=Assoflex");

        }

    }
}