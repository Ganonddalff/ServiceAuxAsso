using System;
using System.Security.Claims;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class PanierController : Controller
    {
        private IDal _dal;

        public PanierController()
        {
            _dal = new Dal();
        }
        // GET
        public IActionResult Index(int idUser)
        {
            Panier panier = _dal.GetPanierByUserId(idUser);
            panier.ArticlesPanier = _dal.GetArticlesPanierByPanierId(panier.Id);
            LayoutModelView lModelView = new LayoutModelView()
            {
                Associations = _dal.GetAllAssociations(),
                Evenements = _dal.GetAllEvenements(),
                Crowdfundings = _dal.GetAllCrowdfundings(),
                Panier = panier,
            };
            return View(lModelView);
        }
    }
}