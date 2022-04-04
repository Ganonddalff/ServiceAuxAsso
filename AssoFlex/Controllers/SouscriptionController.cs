using System;
using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class SouscriptionController : Controller
    {
        private IDal _dal;

        public SouscriptionController()
        {
            _dal = new Dal();
        }
        
        [Authorize]
        // GET
        public IActionResult Index()
        {
            int idUser = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            LayoutModelView lModelView = new LayoutModelView()
            {
                Utilisateur = _dal.GetUtilisateur(idUser),
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                Panier = _dal.GetPanierByUserId(idUser)
            };
            if (lModelView.Panier == null)
            {
                lModelView.Panier = _dal.CreatePanier(_dal.GetUtilisateur(idUser));
            }
            return View(lModelView);
        }

        [HttpPost]
        public IActionResult AddSouscription(LayoutModelView layoutModelView)
        {
            string formule = "Formule 4";
            double montant;
            Utilisateur user = _dal.GetUtilisateur(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (formule == "Formule 4")
            {
                montant = 95;
            }
            else if (formule == "Formule 3" || formule == "Formule 2")
            {
                montant = 50;
            }
            else
            {
                montant = 0;
            }
            var association = _dal.CreateAssociation(
                layoutModelView.Association.Nom,
                layoutModelView.Association.NumSiret,
                user.Id,
                "default-logo.png",
                layoutModelView.Association.CategorieAsso,
                layoutModelView.Association.Description);
            var souscription = _dal.CreateSouscrition(association.Id, formule);
            var panier = _dal.GetPanierByUserId(user.Id);
            ArticlePanier articlePanier = new ArticlePanier()
            {
                Quantite = 1,
                MontantUnitaire = montant,
                PanierId = souscription.Id,
                ProduitNom = souscription.Formule,
                UtilisateurId = user.Id,
                Panier = panier,
                TypeDeCommande = "Souscription",
            };
            if (panier != null)
            {
                _dal.AddArticleToPanier(panier.Id, articlePanier);
            }
            else
            {
                Panier panierNew = _dal.CreatePanier(user);
                _dal.AddArticleToPanier(panierNew.Id, articlePanier);
            }
            if(user.Role.Equals("Admin-Assso").Equals(false))
            {
                _dal.UpdateUtilisateur(user.Id,user.Prenom,user.Nom,user.Adresse,user.Telephone,user.Email,user.Password,user.ProfilImg,"Admin-Asso");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}