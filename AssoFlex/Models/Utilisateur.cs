using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AssoFlex.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int NomComplet { get; set; }
        public string Adresse { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ProfilImg { get; set; }
        // public List<Association> UserAssociations { get; set; }

    }

    public enum Genre
    {
        Homme,
        Femme
    }
}