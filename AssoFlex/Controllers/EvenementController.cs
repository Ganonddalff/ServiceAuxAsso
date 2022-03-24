using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            List<Evenement> listerMesEvenements = _dal.getAllEvenements();
            foreach (var monEvent in listerMesEvenements)
            {
                monEvent.Organisateur = _dal.getAssociation(monEvent.OrganisateurId);
            }
            return View(listerMesEvenements);
        }

        // public ActionResult Details(int id)
        // {
        //     EvenementViewModel evm = new EvenementViewModel();
        //     evm = _dal.getEvenementViewModel(id);
        //     return View(evm);
        // }

        public ActionResult Details(int id)
        {
            Evenement monEvent = _dal.getEvenement(id);
            monEvent.Organisateur = _dal.getAssociation(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
            return View(monEvent);
        }
        //GET
        public ActionResult RechercheEvent(string critereRecherche)
        {
            List<Evenement> uneListeTemporaire = _dal.getAllEvenements();
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
            Evenement evenement = _dal.getEvenement(id);
            return View(evenement);
        }

        [HttpPost]
        public ActionResult ModifEvent(Evenement eventUpdate)
        {
            if (ModelState.IsValid)
            {
                eventUpdate = _dal.UpdateEvenement(eventUpdate.IdEvent, eventUpdate.NomEvent, eventUpdate.NbTickets,
                    eventUpdate.DateDebutEvent, eventUpdate.DateFinEvent, eventUpdate.LieuEvent,
                    eventUpdate.CategorieEvent);
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public Association getOrg(int orgaId)
        {
            Association assoOrga = _dal.getAssociation(orgaId);
            return assoOrga;
        }
        
        //GET
        public ActionResult CreerEvent()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CreerEvent(Evenement evenement)
        {
            if (ModelState.IsValid)
            {
                var orgaID = _dal.getAssociationID(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value));
                Association orga = _dal.getAssociation(orgaID);
                evenement = _dal.CreateEvenement(
                    orga, evenement.NomEvent,
                    evenement.NbTickets, 
                    evenement.DateDebutEvent, evenement.DateFinEvent,
                    evenement.LieuEvent, evenement.CategorieEvent);
                return RedirectToAction("Index");
            }
            return View("Error");
        }

        public IActionResult AchatTicket()
        {
            return View();
        }
    }
}