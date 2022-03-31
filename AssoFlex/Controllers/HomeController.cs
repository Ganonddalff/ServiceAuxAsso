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
            HomeViewModel hvm = new HomeViewModel()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfunding = _dal.GetAllCrowdfundings()

            };
            return View(hvm);
        }




    }

}