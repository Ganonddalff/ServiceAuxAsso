using System.Collections.Generic;
using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class BilletterieController : Controller
    {
        private IDal _dal;

        public BilletterieController()
        {
            this._dal = new Dal();
        }
        
        // GET
        // public ActionResult Index()
        // {
        //     return View();
        // }
    }
}