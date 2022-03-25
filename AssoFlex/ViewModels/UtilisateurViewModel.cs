using AssoFlex.Models;
using Microsoft.AspNetCore.Http;

namespace AssoFlex.ViewModels
{
    public class UtilisateurViewModel
    {
        public Utilisateur Utilisateur { get; set; }
        public IFormFile ProfilImg { get; set; }
        public bool Authentifie { get; set; }
    }
}