using System;
using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

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
        public IActionResult Index()
        {
            List<Crowdfunding> listeDesCrowdfundings = _dal.getAllCrowdfundings();
            return View(listeDesCrowdfundings);
        }

        public ActionResult CreateCrowdfunding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCrowdfunding(Crowdfunding nouveauCrowdfunding)
        {
            var PorteurID = _dal.getAssociationID(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
            Association Porteur = _dal.getAssociation(PorteurID);
            if (ModelState.IsValid){
         
                nouveauCrowdfunding = _dal.CreateCrowdfunding(
                        nouveauCrowdfunding.Nom,
                        nouveauCrowdfunding.MontantProjet,
                        nouveauCrowdfunding.LieuProjet,
                        nouveauCrowdfunding.CategorieProjet,
                        nouveauCrowdfunding.DateDebutProjet,
                        nouveauCrowdfunding.DateFinProjet,
                        Porteur,
                        _dal.CreateCollecte()
                );
                
            }
            return RedirectToAction("Index");
        }
        
        //Get
        public ActionResult Contribute(int cfId, int userId)
        {
            Crowdfunding monCF = _dal.getCFCollecte(cfId);
            Utilisateur monUser = _dal.getUtilisateur(userId);
            Collecte maCollecte = monCF.Collecte;
            ContributionViewModel cvm = new ContributionViewModel()
            {
                Collecte = maCollecte,
                Crowdfunding = monCF,
                Utilisateur = monUser
            };
            return View(cvm);
        }

        [HttpPost]
         public ActionResult Contribute(ContributionViewModel cvm, int cfId, int userId)
         {
             if (cvm.Montant != 0)
             {


                 Crowdfunding monCF = _dal.getCFCollecte(cfId);
                 Utilisateur monUser = _dal.getUtilisateur(userId);
                 Collecte maCollecte = monCF.Collecte;
                 ContributionViewModel cvm2 = new ContributionViewModel()
                 {
                     Collecte = maCollecte,
                     Contribution = _dal.CreateContribution(cvm.Montant, maCollecte.Id, monUser),
                     Crowdfunding = monCF,
                     Utilisateur = monUser
                 };

                 return RedirectToAction("Index", "Crowdfunding");
             }

             return RedirectToAction("Index", "Crowdfunding");
         }
        
        public ActionResult DetailsCrowdfunding(int id)
        {
            Crowdfunding monCF = _dal.getCrowdfunding(id);
            ContributionViewModel cvm = new ContributionViewModel()
            {
                Collecte = _dal.getCollecte(monCF.Id),
                Crowdfunding = _dal.getCrowdfunding(id)

            };
            return View(cvm);
        }

        public ActionResult UpdateCrowdfunding(int id)
        {
            Crowdfunding monCF = _dal.getCrowdfunding(id);
            return View(monCF);
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
                    cfToUpdate.DateFinProjet
                    );
               return RedirectToAction("Index");
            }

            return View("Error");
        }
        
        //GET
        public ActionResult DeleteCrowdfunding(int id)
        {
            Crowdfunding cfToDel = _dal.getCrowdfunding(id);
            if (cfToDel != null)
            {
                _dal.DeleteCrowdfunding(id);
            }
            return RedirectToAction("Index");
        }
    }
}