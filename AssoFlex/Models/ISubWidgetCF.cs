using System;

namespace AssoFlex.Models
{
    public class ISubWidgetCF
    {
        public string Nom { get; set; }
        public DateTime DateFinProjet { get; set; }
        public string CategorieProjet { get; set; }
        public int MontantProjet { get; set; }
        public Collecte Collecte { get; set; }
        public Association PorteurDuProjet { get; set; }
        public string Description { get; set; }
    }
}