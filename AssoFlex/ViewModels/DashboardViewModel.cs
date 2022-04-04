using System.Collections.Generic;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class DashboardViewModel
    {
        private IDal _dal;
        public Utilisateur Admin { get; set; }
        public Association Association { get; set; }
        public Evenement Evenement { get; set; }
        public Crowdfunding Crowdfunding { get; set; }
        public List<Utilisateur> Utilisateurs{ get; set; }
        public List<Association> Associations { get; set; }
        public List<Adhesion> Adhesions { get; set; }
        public List<Evenement> Evenements { get; set; }
        public List<Crowdfunding> Crowdfundings { get; set; }
        
    }
    
    
}