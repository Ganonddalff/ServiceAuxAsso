using System.Collections.Generic;
using AssoFlex.Controllers;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class LayoutModelView
    {
        private IDal _dal;
        
        public LayoutModelView()
        {
            _dal = new Dal();
        }
        public Utilisateur Utilisateur { get; set; }
        public Evenement Evenement { get; set; }
        public Association Association { get; set; }
        public Crowdfunding Crowdfunding { get; set; }
        public Collecte Collecte { get; set; }
        public ContributionViewModel ContributionViewModel { get; set; }
        
        public CheckoutController CheckoutController { get; set; }
        public List<Association> Associations { get; set; }
        public List<Evenement> Evenements { get; set; }
        public List<Crowdfunding> Crowdfundings { get; set; }
        public Panier Panier { get; set; }
        public List<IWidgetAsso> WidgetsAssos { get; set; }
        public List<IWidgetEvent> WidgetsEvents { get; set; }
        public List<IWidgetCF> WidgetsCrowdfundings { get; set; }

        public int GetNombreArticlePanier(string idUser)
        {
            Panier panier = _dal.GetPanierByUserId(idUser);
            panier.ArticlesPanier = _dal.GetArticlesPanierByPanierId(panier.Id);
            if (panier.ArticlesPanier == null)
            {
                return 0;
            }
            return panier.ArticlesPanier.Count;
        }
        public Utilisateur GetUserByClaim(string idUser)
        {
            return _dal.GetUtilisateur(idUser);
        }
    }
}