using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class ContributionViewModel
    {
        public double Montant { get; set; }
        public Crowdfunding Crowdfunding { get; set; }
        public Collecte Collecte { get; set; }
        public Contribution Contribution { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}