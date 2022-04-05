using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Crowdfunding : IWidgetCF
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public int MontantProjet { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateDebutProjet { get; set; }
        public DateTime DateFinProjet { get; set; }
        public string LieuProjet { get; set; }
        [MaxLength(14)]
        public string CategorieProjet { get; set; }
        public bool Statut { get; set; }
        
        public int PorteurDuProjetId { get; set; }
        
        public int CollecteId { get; set; }
        
        public Collecte Collecte { get; set; }

        public Association PorteurDuProjet { get; set; }

        public string ImageCrowdfunding { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public ISubWidgetCF SubWidgetCF { get; set; }

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
