using System.Collections.Generic;

namespace AssoFlex.Models
{
    public class Panier
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public List<ArticlePanier> ArticlesPanier { get; set; }

    }
}