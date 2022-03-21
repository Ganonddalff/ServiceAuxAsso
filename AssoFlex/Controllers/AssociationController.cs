using System.Collections.Generic;
using System.Threading.Tasks;
using AssoFlex.Models;
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
        public IActionResult Index()
        {
            List<Association> listeDesAssociations = _dal.getAllAssociations();
            return View(listeDesAssociations);
        }
        
        // GET
        public ActionResult DetailsAssociation(int id)
        {
            Association association = _dal.getAssociation(id);
            return View(association);
        }
    }
}