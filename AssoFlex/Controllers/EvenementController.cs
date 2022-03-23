using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AssoFlex.Models;

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
            return View(listerMesEvenements);
        }

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

        public ActionResult ModifEvent(int id)
        {
            Evenement evenement = _dal.getEvenement(id);
            return View(evenement);
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
                evenement = _dal.CreateEvenement(
                    evenement.OrganisateurId, evenement.NomEvent,
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