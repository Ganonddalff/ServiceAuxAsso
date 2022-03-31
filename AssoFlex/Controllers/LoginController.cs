using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AssoFlex.Models;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class LoginController : Controller
    {
        private IDal _dal;

        public LoginController()
        {
            this._dal = new Dal();
        }
        // GET
        public IActionResult Index()
        {
            var viewModel = new UtilisateurViewModel()
            {
                Authentifie = HttpContext.User.Identity.IsAuthenticated
            };
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value;
                viewModel.Utilisateur = _dal.GetUtilisateur(userId);
                return Redirect("home/index");
            }
            return View(viewModel);
        }
        
        // POST
        [HttpPost]
        public ActionResult Index(UtilisateurViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var utilisateur = _dal.Authentifier(viewModel.Utilisateur.Email, viewModel.Utilisateur.Password);
                if (utilisateur != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, utilisateur.Prenom),
                        new Claim(ClaimTypes.Email, utilisateur.Email),
                        new Claim(ClaimTypes.NameIdentifier, utilisateur.Id.ToString()),
                        new Claim(ClaimTypes.Role, utilisateur.Role)
                    };
                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] {ClaimIdentity});
                    Panier panierNew = _dal.CreatePanier(viewModel.Utilisateur);
                    HttpContext.SignInAsync(userPrincipal);

                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return Redirect("/");
                }
                ModelState.AddModelError("Utilisateur.Email", "Email et/ou mot de passe incorrect(s)");
            }

            return View(viewModel);
        }
        
        // GET
        public ActionResult CreateCompte()
        {
            return View();
        }
        
        // POST
        [HttpPost]
        public ActionResult CreateCompte(UtilisateurViewModel model, IFormFile imageUpload)
        {
            if (ModelState.IsValid)
            {
                byte[] profilImg;
                using (var memoryStream = new MemoryStream())
                {
                    imageUpload.CopyTo(memoryStream);
                    profilImg = memoryStream.ToArray();
                }
                var userToCreate = _dal.CreateUtilisateur(
                    model.Utilisateur.Prenom,
                    model.Utilisateur.Nom,
                    model.Utilisateur.Adresse,
                    model.Utilisateur.Telephone,
                    model.Utilisateur.Email,
                    model.Utilisateur.Password,
                    profilImg);
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, userToCreate.Prenom),
                    new Claim(ClaimTypes.Email, userToCreate.Email),
                    new Claim(ClaimTypes.NameIdentifier, userToCreate.Id.ToString()),
                    new Claim(ClaimTypes.Role, userToCreate.Role)
                };
                var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");
                var userPrincipal = new ClaimsPrincipal(new[] {ClaimIdentity});
                Panier panierNew = _dal.CreatePanier(userToCreate);
                HttpContext.SignInAsync(userPrincipal);
                return Redirect("/");
            }

            return RedirectToAction("Index", "Home");
        }

        // GET
        public ActionResult Deconnexion()
        {
            //_dal.DeletePanier();
            HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}