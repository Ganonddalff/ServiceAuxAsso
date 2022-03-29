using System;

namespace AssoFlex.Models
{
    public class Crowdfunding
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int MontantProjet { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateDebutProjet { get; set; }
        public DateTime DateFinProjet { get; set; }
        public string LieuProjet { get; set; }
        public string CategorieProjet { get; set; }
        public bool Statut { get; set; }
        
        public int PorteurDuProjetId { get; set; }
        
        public int CollecteId { get; set; }
        
        public Collecte Collecte { get; set; }

        public Association PorteurDuProjet { get; set; }

    }

    public enum TypesProjet
    {
        Education = 1,
        Sport = 2,
        Humanitaire = 3,
        Environnement = 4,
        Culture = 5,
        Santé = 6
    }
}
