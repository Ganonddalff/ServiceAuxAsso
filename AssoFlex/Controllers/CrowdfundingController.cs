using System;
using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

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
            if (ModelState.IsValid)
            {
                var PorteurID = _dal.getAssociationID(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
                Association Porteur = _dal.getAssociation(PorteurID);
                nouveauCrowdfunding = _dal.CreateCrowdfunding(
                        nouveauCrowdfunding.Nom,
                        nouveauCrowdfunding.MontantProjet,
                        nouveauCrowdfunding.LieuProjet,
                        nouveauCrowdfunding.CategorieProjet,
                        nouveauCrowdfunding.DateDebutProjet,
                        nouveauCrowdfunding.DateFinProjet,
                        Porteur
                );
            }
            return View("Error");
        }

        public ActionResult DetailsCrowdfunding(int id)
        {
            Crowdfunding monCF = _dal.getCrowdfunding(id);
            return View(monCF);
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