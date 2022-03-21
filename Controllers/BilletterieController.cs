using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
            Methodes meth = new Methodes();
            return View();
        }
    }
}