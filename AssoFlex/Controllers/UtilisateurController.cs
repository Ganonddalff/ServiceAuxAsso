using AssoFlex.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class UtilisateurController : Controller
    {
        private IDal _dal;

        public UtilisateurController()
        {
            this._dal = new Dal();
        }

        public IActionResult DeleteUtilisateur(int id)
        {
            this._dal.DeleteUtilisateur(id);
            return RedirectToAction("DashboardAdmin", "Dashboard");
        }

        public IActionResult UpdateUtilisateur(int id, string prenom, string nom, string adresse,
            int telephone, string email, string password, string role)
        {
            Utilisateur user = this._dal.getUtilisateur(id);
            return View(user);
        }

        [HttpPost]
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