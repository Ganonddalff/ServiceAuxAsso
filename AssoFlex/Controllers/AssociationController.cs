using System.Collections.Generic;
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
        public IActionResult Index()
        {
            List<Association> listeDesAssociations = _dal.GetAllAssociations();
            return View(listeDesAssociations);
        }
        
        // GET
        public ActionResult DetailsAssociation(int id)
        {
            Association association = _dal.GetAssociation(id);
            return View(association);
        }
        
        public ActionResult AddAdhesion(int idAsso, int idUser)
        {
            _dal.CreateAdhesion(idAsso, idUser);
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
                    association.Id, association.Nom, association.NumSiret,
                    association.Description);
                return RedirectToAction("DashboardAdmin", "Dashboard");

            }

            return View("Error");
        }
    }
}