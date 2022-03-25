using System.Security.Claims;
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
                Admin = _dal.getUtilisateur(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                Associations = _dal.getAllAssociations(),
                Utilisateurs = _dal.getAllUtilisateurs(),
                Adhesions = _dal.getAllAdhesions()
            };
            return View(dVM);
        }

        public IActionResult GetImageProfil(int id)
        {
            Utilisateur user = _dal.getUtilisateur(id);
            return File(user.ProfilImg, "image/jpeg");
        }
        
        
        [Authorize(Roles = "Admin-Asso, Basic")]
        // GET
        public IActionResult Profil(int id)
        {
            return View();
        }
        
        
    }
}