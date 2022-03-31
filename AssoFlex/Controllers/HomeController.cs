using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class HomeController : Controller
    {
        private IDal _dal;

        public HomeController()
        {
            this._dal = new Dal();
        }
        // GET
        public IActionResult Index()
        {
            LayoutModelView hvm = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                
            };
            if (User.Identity.IsAuthenticated) /*hvm.Panier == null*/
            {
                hvm.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
                // hvm.Panier = _dal.CreatePanier(_dal.GetUtilisateur(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            }
            return View(hvm);
        }
    }
}