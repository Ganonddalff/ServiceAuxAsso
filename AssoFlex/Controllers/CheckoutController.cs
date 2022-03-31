using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class CheckoutController : Controller
    {
        private IDal _dal;

        public CheckoutController()
        {
            _dal = new Dal();
        }
        // GET
        public IActionResult Index()
        {
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier))
            };
            if (lModelView.Panier == null)
            {
                lModelView.Panier = _dal.CreatePanier(_dal.GetUtilisateur(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            }
            return View(lModelView);
        }
    }
}