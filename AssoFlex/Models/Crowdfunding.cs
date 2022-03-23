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

    }
}
