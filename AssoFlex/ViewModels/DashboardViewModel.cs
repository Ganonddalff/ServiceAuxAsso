using System.Collections.Generic;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class DashboardViewModel
    {
        public Utilisateur Admin { get; set; }
        public List<Utilisateur> Utilisateurs{ get; set; }
        public List<Association> Associations { get; set; }
        public List<Adhesion> Adhesions { get; set; }
        public List<Evenement> Evenements { get; set; }
        public List<Crowdfunding> Crowdfundings { get; set; }
    }
}