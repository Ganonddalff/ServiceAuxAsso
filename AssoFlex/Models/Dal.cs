using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AssoFlex.Models
{
    public class Dal : IDal
    {
        private AssoFlexContext _assoFlex;

        public Dal()
        {
            this._assoFlex = new AssoFlexContext();
        }
        
        public void Dispose()
        {
           this._assoFlex.Dispose();
        }

        public void InitializeDb()
        {
            this._assoFlex.Database.EnsureDeleted();
            this._assoFlex.Database.EnsureCreated();
            this.CreateUtilisateur(
                "Guytri", "Kastane", "31 rue de l'aurore", 0755172316, "gkastane@gmail.com",
                EncodeMD5("11111"), "Admin");
            this.CreateUtilisateur(
                "Paul", "Jean", "78 rue de l'aurore", 0755172316, "pjean@gmail.com",
                EncodeMD5("22222"));
            this.CreateAssociation(
                "AGP", 
                "111111-111", 
                "Association des Gabonais de Poitiers");
            this.CreateAssociation(
                "ASTEC",
                "222222-222",
                "L'Association pour la Science et la Transmission de l'Esprit Critique a pour principal projet la chaîne YouTube la Tronche en Biais.");
            this.CreateAssociation(
            "Tête en l'air",
            "333333-333",
            "Depuis 2006, nous avons pour objectif de faire partager à un large public notre passion. A ce titre, nos membres se déplacent avec leur matériel dans les écoles, centres de loisirs, associations, soirées privées etc.");

        }

        public Utilisateur getUtilisateur(int id)
        {
            
            return this._assoFlex.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public Utilisateur getUtilisateur(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.getUtilisateur(id) : null;
        }

        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "Assoflex" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(
                new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }
        public Utilisateur Authentifier(string email, string password)
        {
            var motDePasse = EncodeMD5(password);
            var user = this._assoFlex.Utilisateurs.FirstOrDefault(u => 
                u.Email == email && u.Password == motDePasse);
            return user;
        }

        public List<Utilisateur> getAllUtilisateurs()
        {
            return _assoFlex.Utilisateurs.ToList();
        }

        public Utilisateur CreateUtilisateur(string prenom, string nom, string adresse, int telephone, string email,
            string password, string role="Basic")
        {
            Utilisateur userToAdd = new Utilisateur()
            {
                Prenom = prenom,
                Nom = nom,
                Adresse = adresse,
                Telephone = telephone,
                Email = email,
                Password = password,
                Role = role
            };
            this._assoFlex.Utilisateurs.Add(userToAdd);
            this._assoFlex.SaveChanges();
            return userToAdd;
        }

        public void UpdateUtilisateur(int id, string prenom, string nom, string adresse, int telephone, string email,
            string password, string role)
        {
            Utilisateur userToUpdate = this._assoFlex.Utilisateurs.Find(id);
            if (userToUpdate != null)
            {
                userToUpdate.Prenom = prenom;
                userToUpdate.Nom = nom;
                userToUpdate.Adresse = adresse;
                userToUpdate.Telephone = telephone;
                userToUpdate.Email = email;
                userToUpdate.Password = password;
                userToUpdate.Role = role;
                this._assoFlex.SaveChanges();
            }
        }

        public void DeleteUtilisateur(int id)
        {
            Utilisateur userToDelete = this._assoFlex.Utilisateurs.Find(id);
            if (userToDelete != null)
            {
                this._assoFlex.Utilisateurs.Remove(userToDelete);
                this._assoFlex.SaveChanges();
            }
        }

        public Association getAssociation(int id)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.Id == id);
        }

        public Association getAssociation(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.getAssociation(id) : null;
        }

        public List<Association> getAllAssociations()
        {
            return _assoFlex.Associations.ToList();
        }

        public Association CreateAssociation(string nom, string numSiret, string description = "")
        {
            Association assoToAdd = new Association()
            {
                Nom = nom,
                NumSiret = numSiret,
                DateInscription = DateTime.Now,
                Description = description,
            };
            this._assoFlex.Associations.Add(assoToAdd);
            this._assoFlex.SaveChanges();
            return assoToAdd;
        }

        public void UpdateAssociation(int id, string nom, string numSiret, string description)
        {
            Association assoToUpdate = this._assoFlex.Associations.Find(id);
            if (assoToUpdate != null)
            {
                assoToUpdate.Nom = nom;
                assoToUpdate.NumSiret = numSiret;
                assoToUpdate.Description = description;
                this._assoFlex.SaveChanges();
            }
        }

        public void DeleteAssociation(int id)
        {
            Association assoToDelete = this._assoFlex.Associations.Find(id);
            if (assoToDelete != null)
            {
                this._assoFlex.Associations.Remove(assoToDelete);
                this._assoFlex.SaveChanges();
            }
        }
    }
}