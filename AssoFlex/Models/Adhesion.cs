using System;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Adhesion
    {
        public int Id { get; set; }
        public int AssociationId { get; set; }
        public Association Association { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int AdhesionArticleId { get; set; }
        public AdhesionArticle AdhesionArticle { get; set; }
    }
}