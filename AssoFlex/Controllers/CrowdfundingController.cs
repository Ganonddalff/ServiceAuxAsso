using System;
using System.Collections.Generic;
using System.Linq;
using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using AssoFlex.ViewModels;
namespace AssoFlex.Controllers
{
    public class CrowdfundingController : Controller
    {
        private IDal _dal;

        public CrowdfundingController()
        {
            this._dal = new Dal();
        }
        // GET
        public IActionResult Index(string searchString)
        {
            List<IWidgetCF> widgetCfs = _dal.GetCrowdfundingsToWidget();
            if (!string.IsNullOrEmpty(searchString))
            {
                widgetCfs = widgetCfs.Where(s => s.Nom.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                
                WidgetsAssos = _dal.GetAssociationsToWidget(),
                WidgetsEvents = _dal.GetEventToWidget(),
                WidgetsCrowdfundings = widgetCfs,
            };
            if (User.Identity.IsAuthenticated) /*lModelView.Panier == null*/
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            return View(lModelView);
        }

        // public ActionResult CreateCrowdfunding()
        // {
        //     return View();
        // }

        [HttpPost]
        public ActionResult CreateCrowdfunding(Crowdfunding crowdfunding)
        {
            if (ModelState.IsValid){
                var PorteurID = _dal.GetAssociationId(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
                Association Porteur = _dal.GetAssociation(PorteurID);
                crowdfunding = _dal.CreateCrowdfunding(
                    crowdfunding.Nom,
                    crowdfunding.MontantProjet,
                    crowdfunding.LieuProjet,
                    crowdfunding.CategorieProjet,
                    crowdfunding.DateDebutProjet,
                    crowdfunding.DateFinProjet,
                    Porteur,
                    _dal.CreateCollecte(),
                    crowdfunding.ImageCrowdfunding,
                    crowdfunding.Description
                );
                return RedirectToAction("DashboardUser", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value});
            }

            return View("Error");
        }
            
        
        //Get
        // public ActionResult Contribute(int cfId, int userId)
        // {
        //     Crowdfunding crowdfunding = _dal.GetCfCollecte(cfId);
        //     Utilisateur user = _dal.GetUtilisateur(userId);
        //     Collecte collecte = crowdfunding.Collecte;
        //     var panier = _dal.GetPanierByUserId(userId);
        //     ArticlePanier articlePanier = new ArticlePanier()
        //     {
        //         Quantite = 1,
        //         MontantUnitaire = 0,
        //         ProduitId = crowdfunding.Id,
        //         ProduitNom = crowdfunding.Nom,
        //         UtilisateurId = userId,
        //         Panier = panier,
        //         TypeDeCommande = "Crowdfunding",
        //     };
        //     if ( panier != null)
        //     {
        //         _dal.AddArticleToPanier(panier.Id,articlePanier);
        //     }
        //     else
        //     {
        //         Panier panierNew = _dal.CreatePanier(user);
        //         _dal.AddArticleToPanier(panierNew.Id, articlePanier);
        //     }
        //     return RedirectToAction("Index");
        // }

        [HttpPost]
         public ActionResult Contribute(int cfId, int userId, int montant)
         {
             if (montant != 0)
             {
                 Crowdfunding monCF = _dal.GetCfCollecte(cfId);
                 Utilisateur monUser = _dal.GetUtilisateur(userId);
                 var panier = _dal.GetPanierByUserId(userId);
                 Collecte maCollecte = monCF.Collecte;
                 ContributionViewModel cvm2 = new ContributionViewModel()
                 {
                     Collecte = maCollecte,
                     Contribution = _dal.CreateContribution(montant, maCollecte.Id, monUser),
                     Crowdfunding = monCF,
                     Utilisateur = monUser
                 };
                 
                 ArticlePanier articlePanier = new ArticlePanier()
                 {
                     Quantite = 1,
                     MontantUnitaire = montant,
                     ProduitId = monCF.Id,
                     ProduitNom = monCF.Nom,
                     UtilisateurId = userId,
                     Panier = panier,
                     TypeDeCommande = "Crowdfunding",
                 };
                 if ( panier != null)
                 {
                     _dal.AddArticleToPanier(panier.Id,articlePanier);
                 }
                 else
                 {
                     Panier panierNew = _dal.CreatePanier(monUser);
                     _dal.AddArticleToPanier(panierNew.Id, articlePanier);
                 }

                 return RedirectToAction("Index", "Crowdfunding");
             }

             return RedirectToAction("Index", "Crowdfunding");
         }
        
        public ActionResult DetailsCrowdfunding(int id)
        {
            Crowdfunding monCF = _dal.GetCrowdfunding(id);
            ContributionViewModel cvm = new ContributionViewModel()
            {
                Collecte = _dal.GetCollecte(monCF.Id),
                Crowdfunding = _dal.GetCrowdfunding(id)
                
            };
            LayoutModelView layoutModelView = new LayoutModelView()
            {
                ContributionViewModel = cvm
            };
            
            return View(layoutModelView);
        }

        public ActionResult UpdateCrowdfunding(int id)
        {
            Crowdfunding monCF = _dal.GetCrowdfunding(id);
            return Ok(); /*View(monCF);*/
        }

        [HttpPost]
        public ActionResult UpdateCrowdfunding(Crowdfunding cfToUpdate)
        {
            if (ModelState.IsValid)
            {
                cfToUpdate = _dal.UpdateCrowdfunding(
                    cfToUpdate.Id,
                    cfToUpdate.Nom,
                    cfToUpdate.MontantProjet,
                    cfToUpdate.LieuProjet,
                    cfToUpdate.CategorieProjet,
                    cfToUpdate.DateFinProjet,
                    cfToUpdate.ImageCrowdfunding,
                    cfToUpdate.Description
                );
               return RedirectToAction("Index");
            }

            return View("Error");
        }
        
        //GET
        public ActionResult DeleteCrowdfunding(int id)
        {
            Crowdfunding cfToDel = _dal.GetCrowdfunding(id);
            if (cfToDel != null)
            {
                _dal.DeleteCrowdfunding(id);
            }
            return RedirectToAction("DashboardUser", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value});
        }
    }
}