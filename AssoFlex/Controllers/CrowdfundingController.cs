using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    }
}