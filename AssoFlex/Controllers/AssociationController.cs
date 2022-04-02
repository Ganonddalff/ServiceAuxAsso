using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class AssociationController : Controller
    {
        private IDal _dal;

        public AssociationController()
        {
            this._dal = new Dal();
        }
        
        // GET
        public IActionResult Index(string searchString)
        {
            List<IWidgetAsso> widgetsAssos = _dal.GetAssociationsToWidget();;
            if (!String.IsNullOrEmpty(searchString))
            {
                widgetsAssos = _dal.GetAssociationsToWidget().Where(s => s.Nom.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(), 
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                
                WidgetsAssos = widgetsAssos,
                WidgetsEvents = _dal.GetEventToWidget(),
                WidgetsCrowdfundings = _dal.GetCrowdfundingsToWidget(),
            };
            if (User.Identity.IsAuthenticated) /*lModelView.Panier == null*/
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            
            return View(lModelView);
        }
        
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
        
        // GET
        public ActionResult DetailsAssociation(int id)
        {
            Association association = _dal.GetAssociation(id);
            LayoutModelView layoutModelView = new LayoutModelView()
            {
                Association = association
            };
            return View(layoutModelView);
        }
        
        public ActionResult AddAdhesion(int idAsso, int idUser, int adhesionArticleId)
        {
            Utilisateur user = _dal.GetUtilisateur(idUser);
            AdhesionArticle adhesionArticle = _dal.GetAdhesionArticle(1);
            Association association = _dal.GetAssociation(idAsso);
            var panier = _dal.GetPanierByUserId(idUser);
            ArticlePanier articlePanier = new ArticlePanier()
            {
                Quantite = 1,
                MontantUnitaire = adhesionArticle.MontantAdh,
                ProduitId = adhesionArticle.Id,
                ProduitNom = adhesionArticle.Nom,
                UtilisateurId = idUser,
                Panier = panier,
                TypeDeCommande = "Adhesion",
            };
            if ( panier != null)
            {
                _dal.AddArticleToPanier(panier.Id,articlePanier);
            }
            else
            {
                Panier panierNew = _dal.CreatePanier(user);
                _dal.AddArticleToPanier(panierNew.Id, articlePanier);
            }
            
            // _dal.CreateAdhesion(idAsso, idUser);
            return RedirectToAction("Index");
        }

        // GET
        public IActionResult DeleteAssociation(int id)
        {
            if (_dal.GetAssociation(id) != null)
            {
                _dal.DeleteAssociation(id);
                return RedirectToAction("DashboardAdmin", "Dashboard");
            }
            return View("Error");
        }
        
        // GET
        public IActionResult UpdateAssociation(int id, string nom, string numSiret, string description)
        {
            Association association = this._dal.GetAssociation(id);
            return View(association);
        }

        [HttpPost]
        public IActionResult UpdateAssociation(Association association)
        {
            if (ModelState.IsValid)
            {
                this._dal.UpdateAssociation(
                    association.Id, 
                    association.Nom, 
                    association.NumSiret,association.AdminAssoId,
                    association.AssoLogo, 
                    association.CategorieAsso,
                    association.Description);
                return RedirectToAction("DashboardAdmin", "Dashboard");

            }

            return View("Error");
        }
        public IActionResult GetImageAsso(int id)
        {
            Association asso = _dal.GetAssociation(id);
            return File(asso.AssoLogo, "image/png");
        }

        // public IActionResult SearchAsso()
        // {
        //     throw new NotImplementedException();
        // }
    }
}