using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;

namespace AssoFlex.Controllers
{
    public class EvenementController : Controller
    {
        private IDal _dal;

        public EvenementController()
        {
            this._dal = new Dal();
        }

        // GET
        public ActionResult Index(string searchString)
        {
            List<IWidgetEvent> widgetEvents = _dal.GetEventToWidget();
            if (!string.IsNullOrEmpty(searchString))
            {
                widgetEvents = widgetEvents
                    .Where(s => s.NomEvent.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                WidgetsAssos = _dal.GetAssociationsToWidget(),
                WidgetsEvents = widgetEvents,
                WidgetsCrowdfundings = _dal.GetCrowdfundingsToWidget(),
            };
            if (User.Identity.IsAuthenticated) /*lModelView.Panier == null*/
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            foreach (var monEvent in lModelView.Evenements)
            {
                monEvent.Organisateur = _dal.GetAssociation(monEvent.OrganisateurId);
            }
            return View(lModelView);
        }
        
        public ActionResult Details(int id)
        {
            Evenement monEvent = _dal.GetEvenement(id);
            LayoutModelView layoutModelView = new LayoutModelView()
            {
                Evenement = monEvent
            };
            return View(layoutModelView);
        }
        //GET
        public ActionResult RechercheEvent(string critereRecherche)
        {
            List<Evenement> uneListeTemporaire = _dal.GetAllEvenements();
            List<Evenement> resultatRecherche = new List<Evenement>();

            foreach (var eventRecherche in uneListeTemporaire)
            {
                if (eventRecherche.NomEvent.Equals(critereRecherche))
                {
                    resultatRecherche.Add(eventRecherche);
                }

                if (eventRecherche.Organisateur.Nom.Equals(critereRecherche))
                {
                    resultatRecherche.Add(eventRecherche);
                }

                if (eventRecherche.LieuEvent.Equals(critereRecherche))
                {
                    resultatRecherche.Add(eventRecherche);
                }
            }

            return View(resultatRecherche);
        }
        //GET
        public ActionResult ModifEvent(int id)
        {
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                Evenement = _dal.GetEvenement(id)

            };
            if (User.Identity.IsAuthenticated) /*lModelView.Panier == null*/
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }

            return Ok(); /*View(lModelView);*/
        }

        [HttpPost]
        public ActionResult ModifEvent(Evenement eventUpdate)
        {
            if (ModelState.IsValid)
            {
                eventUpdate = _dal.UpdateEvenement(eventUpdate.IdEvent, 
                    eventUpdate.NomEvent, 
                    eventUpdate.NbTickets,
                    eventUpdate.DateDebutEvent, 
                    eventUpdate.DateFinEvent, 
                    eventUpdate.LieuEvent,
                    eventUpdate.VisuelEvent,
                    eventUpdate.CategorieEvent, 
                    eventUpdate.Prix);
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public Association getOrg(int orgaId)
        {
            Association assoOrga = _dal.GetAssociation(orgaId);
            return assoOrga;
        }
        
        //GET
        public ActionResult CreerEvent()
        {
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
            };
            if (User.Identity.IsAuthenticated)
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }

            return Ok(); /*View(lModelView);*/
        }
        
        [HttpPost]
        public ActionResult CreerEvent(Evenement evenement)
        {
            if (ModelState.IsValid)
            {
                var orgaID = _dal.GetAssociationId(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
                Association orga = _dal.GetAssociation(orgaID);
                evenement = _dal.CreateEvenement(
                    orga, evenement.NomEvent,
                    evenement.NbTickets, 
                    evenement.DateDebutEvent, evenement.DateFinEvent,
                    evenement.LieuEvent, evenement.VisuelEvent,evenement.CategorieEvent,evenement.Prix,
                    evenement.Description, evenement.ytURL);
                return RedirectToAction("DashboardUser", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value});
            }
            return View("Error");
        }

        public ActionResult SupprEvent(int id)
        {
            Evenement eventToDel = _dal.GetEvenement(id);
            if (eventToDel != null)
            {
                _dal.DeleteEvenement(id);
            }
            return RedirectToAction("DashboardUser", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value});
        }
        
        public IActionResult AchatTicket(int idEvent, int idUser)
        {
            Utilisateur user = _dal.GetUtilisateur(idUser);
            Evenement evenement = _dal.GetEvenement(idEvent);
            var panier = _dal.GetPanierByUserId(idUser);
            ArticlePanier articlePanier = new ArticlePanier()
            {
                Quantite = 1,
                MontantUnitaire = evenement.Prix,
                ProduitId = evenement.IdEvent,
                ProduitNom = evenement.NomEvent,
                UtilisateurId = idUser,
                Panier = panier,
                TypeDeCommande = "Evenement",
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
            return RedirectToAction("Details","Evenement", new {id=idEvent});
        }
    }
}