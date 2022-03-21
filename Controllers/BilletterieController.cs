using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceBilletterie.Models;

namespace ServiceBilletterie.Controllers
{
    public class BilletterieController : Controller
    {
        // GET
        public ActionResult Index()
        {
            Methodes meth = new Methodes();
            List<Evenements> listerMesEvenements = meth.ObtenirEvent();
            return View(listerMesEvenements);
        }

        public ActionResult AchatTicket()
        {
            return View();
        }

        public ActionResult CreerEvent()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult CreerEvent(Evenements eventACreer)
        {
             if (ModelState.IsValid)
            {
                Methodes _methodes = new Methodes();
                var creationEvent = _methodes.CreerEvenement(
                eventACreer.Organisateur,
                eventACreer.NomEvent,
                eventACreer.LieuEvent,
                eventACreer.CategorieEvent,
                eventACreer.DateDebutEvent,
                eventACreer.DateFinEvent,
                eventACreer.NbTickets,
                true
                
                );
                return RedirectToAction("Index");
            }
            return View("Error");

        }
    }
}