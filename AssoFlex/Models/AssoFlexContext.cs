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
        public DbSet<AdhesionArticle> AdhesionArticles { get; set; }
        public DbSet<Souscription> Souscriptions { get; set; }
        public DbSet<Crowdfunding> Crowdfundings { get; set; }
        public DbSet<Contrepartie> Contreparties { get; set; }
        public DbSet<Collecte> Collectes { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<Billetterie> Billetteries { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<LigneDeCommande> LignesDeCommande { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<ArticlePanier> ArticlesPanier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=Assoflex");
            }
            else
            {
                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            }


        }

    }
}