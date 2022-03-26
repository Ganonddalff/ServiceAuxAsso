using System;

namespace AssoFlex.Models
{
    public class Contribution
    {
        public int Id{ get; set; }
             
        public int MontantContribution { get; set; }
        public DateTime DateContribution { get; set; }
        public int utilisateurId { get; set; }
        public Utilisateur utilisateur { get; set; }
        public int collecteId { get; set; }
        public Collecte collecte { get; set; }
    }
}
