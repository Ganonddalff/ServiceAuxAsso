using System.Collections.Generic;
using System.Linq;
using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace AssoFlex.Controllers
{
    public class UtilisateurController : Controller
    {
        private IDal _dal;

        public UtilisateurController()
        {
            this._dal = new Dal();
        }

        public IActionResult GetUtilisateur(int id)
        {
            Utilisateur user = _dal.GetUtilisateur(id);
            return View(user);
        }

        public IActionResult GetAdhesions(int id)
        {
            List<Adhesion> allAdhesions = _dal.GetAllAdhesions();
            List<Adhesion> listeAdhesion = allAdhesions.Where(adhesion => adhesion.UtilisateurId == id).ToList();
            return View(listeAdhesion);
        }

        public IActionResult GetEvenements(int id)
        {
            List<Reservation> allReservations = _dal.GetAllReservations();
            List<Reservation> listReservations = allReservations.Where(e => e.UserId == id).ToList();
            return View(listReservations);
        }
        
        public IActionResult GetCrowdfundings(int id)
        {
            List<Contribution> allContributions = _dal.GetAllContributions();
            List<Contribution> listContributions = allContributions.Where(e => e.utilisateurId == id ).ToList();
            return View(listContributions);
        }

        public IActionResult DeleteUtilisateur(int id)
        {
            this._dal.DeleteUtilisateur(id);
            return RedirectToAction("DashboardAdmin", "Dashboard");
        }

        public IActionResult UpdateUtilisateur(int id, string prenom, string nom, string adresse,
            int telephone, string email, string password, string role)
        {
            Utilisateur user = this._dal.GetUtilisateur(id);
            return View(user);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult UpdateUtilisateur(Utilisateur user)
        {
            if (ModelState.IsValid)
            {
                this._dal.UpdateUtilisateur(
                    user.Id, user.Prenom, user.Nom, user.Adresse, user.Telephone,
                    user.Email, user.Password, user.ProfilImg,user.Role);
                return RedirectToAction("DashboardAdmin", "Dashboard");
            }

            return View("Error");
        }
    }
}