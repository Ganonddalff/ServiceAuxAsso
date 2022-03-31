using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class PresentationController : Controller
    {
        private IDal _dal;

        public PresentationController()
        {
            _dal = new Dal();
        }
        
        public IActionResult Index()
        {
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                
            };
            if (User.Identity.IsAuthenticated) /*lModelView.Panier == null*/
            {
                lModelView.Panier = _dal.GetPanierByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
                // lModelView.Panier = _dal.CreatePanier(_dal.GetUtilisateur(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            }
            return View(lModelView);
        }
        public IActionResult VoirCvBillal()
        {
            return View();
        }

        public IActionResult VoirCvGuytri()
        {
            return View();
        }

        public IActionResult VoirCvMateusz()
        {
            return View();
        }

        public IActionResult VoirCvPaul()
        {
            return View();
        }

    }
}
