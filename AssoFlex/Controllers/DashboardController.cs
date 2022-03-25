using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class DashboardController : Controller
    {
        private IDal _dal;

        public DashboardController()
        {
            this._dal = new Dal();
        }

        [Authorize(Roles = "Admin")]
        // GET
        public IActionResult DashboardAdmin()
        {
            DashboardViewModel dVM = new DashboardViewModel()
            {
                Associations = _dal.getAllAssociations(),
                Utilisateurs = _dal.getAllUtilisateurs(),
                Adhesions = _dal.getAllAdhesions()
            };
            return View(dVM);
        }
        //suppression Billal
        public IActionResult SupprimerAssociation(int id)
        {

            _dal.DeleteAssociation(id);

            return RedirectToAction("DashboardAdmin", "Dashboard");
        }



        [Authorize(Roles = "Admin-Asso, Basic")]
        // GET
        IActionResult Profil(int id)
        {
            return View();
        }
    }
}











