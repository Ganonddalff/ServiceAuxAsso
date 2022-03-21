using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private IDal _dal;

        public DashboardController()
        {
            this._dal = new Dal();
        }
        
        // GET
        public IActionResult Index()
        {
            DashboardViewModel dVM = new DashboardViewModel()
            {
                Associations = _dal.getAllAssociations(),
                Utilisateurs = _dal.getAllUtilisateurs()
            };
            return View(dVM);
        }
    }
}