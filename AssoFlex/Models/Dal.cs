using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AssoFlex.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AssoFlex.Models
{
    public class Dal : IDal
    {
        private const string DefaultAvatar = "wwwroot/assets/img/avatar.jpeg";
        private AssoFlexContext _assoFlex;

        public Dal()
        {
            this._assoFlex = new AssoFlexContext();
        }
        
        public void Dispose()
        {
           this._assoFlex.Dispose();
        }

        public byte[] ImageToByteArray() //Image image
        {
            return System.IO.File.ReadAllBytes(DefaultAvatar);
        }

        public void InitializeDb()
        {
            this._assoFlex.Database.EnsureDeleted();
            this._assoFlex.Database.EnsureCreated();

            this.CreateUtilisateur(
                "Guytri",
                "Kastane",
                "31 rue de l'aurore",
                0755172316,
                "gkastane@gmail.com",
                EncodeMD5("11111"),
                ImageToByteArray(),"Admin");
            
            this.CreateUtilisateur(
                "Mateusz",
                "Tirel",
                "19, rue des petites murailles",
                0667127014,
                "admin",
                EncodeMD5("admin"),
                ImageToByteArray(),"Admin");
            
            this.CreateUtilisateur(
                "Billal",
                "Benziane",
                "32 rue de l'aurore",
                0755172317,
                "billal.benziane1@gmail.com",
                EncodeMD5("11111"), 
                ImageToByteArray(),"Admin");
            
            this.CreateUtilisateur(
                "Paul",
                "Jean",
                "78 rue de l'aurore",
                0755172320,
                "pjean@gmail.com",
                EncodeMD5("22222"), 
                ImageToByteArray(),"Admin-Asso");
            
            this.CreateUtilisateur(
                "Jean",
                "Jacques",
                "",
                0755172324,
                "jjacques@gmail.com", 
                EncodeMD5("33333"), 
                ImageToByteArray(),"Admin-Asso");
            
            this.CreateUtilisateur(
                "Jessica",
                "Alba", 
                "",
                0755172328,
                "jalba@gmail.com",
                EncodeMD5("44444"), 
                ImageToByteArray(),"Admin-Asso");
            
            this.CreateUtilisateur(
                "Louis",
                "David",
                "",
                0755172332,
                "ldavid@gmail.com",
                EncodeMD5("55555"),
                ImageToByteArray());
            
            this.CreateUtilisateur(
                "Alban",
                "Ivanoff",
                "",
                0755172338,
                "aivanoff@gmail.com",
                EncodeMD5("66666"),
                ImageToByteArray());
            
            this.CreateAssociation(
                "AGP", 
                "111111-111", 
                2,
                "Association des Gabonais de Poitiers");
            
            this.CreateAssociation(
                "ASTEC",
                "222222-222",
                3,
                "L'Association pour la Science et la " +
                "Transmission de l'Esprit Critique a pour principal" +
                " projet la chaîne YouTube la Tronche en Biais.");
            
            this.CreateAssociation(
            "Tête en l'air",
            "333333-333",
            4,
            "Depuis 2006, nous avons pour objectif de faire partager à un large public notre passion. " +
            "A ce titre, nos membres se déplacent avec leur matériel dans les écoles, centres de loisirs, associations, soirées privées etc.");
            
            this.CreateEvenement(
                this.getAssociation(1),
                "Eminem", 
                50, 
                new DateTime(2022, 12, 30), 
                new DateTime(2022, 12, 30), 
                "ACCORD ARENA", 
                "5",
                0);
            this.CreateEvenement(
                this.getAssociation(1),
                "PNL",
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                0);
            this.CreateEvenement(
                this.getAssociation(3),
                "Eminem", 
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                0);

            this.CreateEvenement(
                this.getAssociation(2),
                "Concert super",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Paris",
                "1",
                0);

            this.CreateCrowdfunding(
                "Jackson",
                10000,
                "Montreuil",
                "1", 
                new DateTime(2022, 04, 22),
                new DateTime(2023, 04, 21),
                this.getAssociation(1)
                );

            this.CreateCrowdfunding(
                "Weah",
                200000,
                "Australie",
                "2",
                new DateTime(2022, 08, 13),
                new DateTime(2023, 02, 12),
                this.getAssociation(2)
                );

            this.CreateCrowdfunding(
                "Sawadogo",
                350000,
                "Burkina-Faso",
                "3",
                new DateTime(2022, 10, 01),
                new DateTime(2023, 09, 30),
                this.getAssociation(3)
                );

            this.CreateCrowdfunding(
                "Rajomalala",
                1000000,
                "Madagascar",
                "1",
                new DateTime(2022, 11, 02),
                new DateTime(2023, 07, 18),
                this.getAssociation(1)
                );

            this.CreateCrowdfunding(
                "Jefferson",
                30000,
                "Dallas", 
                "2",
                new DateTime(2022, 06, 27),
                new DateTime(2023, 05, 30),
                this.getAssociation(2)
                );

            this.CreateCrowdfunding(
                "Nguyen",
                80000,
                "Vietnam",
                "2",
                new DateTime(2022, 09, 22),
                new DateTime(2023, 05, 01),
                this.getAssociation(2)
                );

            this.CreateCrowdfunding(
                "Benjamin",
                450000,
                "Montpellier",
                "1",
                new DateTime(2022, 12, 24),
                new DateTime(2023, 11, 21),
                this.getAssociation(3)
                );
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
            string password, byte[] profilImg, string role="Basic")
        {
            Utilisateur userToAdd = new Utilisateur()
            {
                Prenom = prenom,
                Nom = nom,
                Adresse = adresse,
                Telephone = telephone,
                Email = email,
                Password = password,
                ProfilImg = profilImg,
                Role = role
            };
            this._assoFlex.Utilisateurs.Add(userToAdd);
            this._assoFlex.SaveChanges();
            return userToAdd;
        }

        public void UpdateUtilisateur(int id, string prenom, string nom, string adresse, int telephone, string email,
            string password, byte[] profilImg, string role)
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
                userToUpdate.ProfilImg = profilImg;
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

        public int getAssociationID(int idAdmin)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.AdminAssoId == idAdmin).Id;
        }

        public List<Association> getAllAssociations()
        {
            return _assoFlex.Associations.ToList();
        }

        public Association CreateAssociation(string nom, string numSiret, int idGerant, string description = "")
        {
            Association assoToAdd = new Association()
            {
                Nom = nom,
                NumSiret = numSiret,
                DateInscription = DateTime.Now,
                Description = description,
                AdminAsso = this._assoFlex.Utilisateurs.Find(idGerant)
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

        public List<Adhesion> getAllAdhesions()
        {
            return this._assoFlex.Adhesions.ToList();
        }

        public Adhesion CreateAdhesion(int idAsso, int idUser)
        {
            Adhesion adhesionToAdd = new Adhesion()
            {
                Association = this._assoFlex.Associations.Find(idAsso),
                Utilisateur = this._assoFlex.Utilisateurs.Find(idUser),
                DateDebut = DateTime.Now,
                DateFin = DateTime.Now.AddYears(1)
            };
            this._assoFlex.Adhesions.Add(adhesionToAdd);
            this._assoFlex.SaveChanges();
            return adhesionToAdd;
        }

        public void UpdateAdhesion()
        {
            throw new NotImplementedException();
        }

        public void DeleteAdhesion(int id)
        {
            Adhesion adhesionToDelete = this._assoFlex.Adhesions.Find(id);
            this._assoFlex.Adhesions.Remove(adhesionToDelete);
            this._assoFlex.SaveChanges();
        }

        public List<Souscription> getAllSouscriptions()
        {
            return this._assoFlex.Souscriptions.ToList();
        }

        public Souscription getSouscription(int id)
        {
            throw new NotImplementedException();
        }

        public Souscription CreateSouscrition(int id, string formule="Formule 0")
        {
           Association association = this._assoFlex.Associations.Find(id);
           Souscription souscriptionToAdd = new Souscription()
           {
               Association = association,
               DateDebut = DateTime.Now,
               DateFin = DateTime.Now.AddYears(1),
               Formule = formule
           };
           this._assoFlex.Souscriptions.Add(souscriptionToAdd);
           this._assoFlex.SaveChanges();
           return souscriptionToAdd;
        }

        public void UpdateSouscription()
        {
            throw new NotImplementedException();
        }

        public void DeleteSouscription(int id)
        {
           Souscription souscriptionToDelete = this._assoFlex.Souscriptions.Find(id);
           this._assoFlex.Souscriptions.Remove(souscriptionToDelete);
           this._assoFlex.SaveChanges();
        }

        public Crowdfunding getCrowdfunding(int Id)
        {
            return _assoFlex.Crowdfundings.Include(c => c.PorteurDuProjet).ThenInclude(e => e.AdminAsso).FirstOrDefault(a => a.Id==Id);
        }
        public List<Crowdfunding> getAllCrowdfundings()
        {
            return _assoFlex.Crowdfundings.ToList();
        }

        public Crowdfunding CreateCrowdfunding(string Nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateDebut,
            DateTime DateFin, Association Porteur)
        {
            Crowdfunding crowdfundingToAdd = new Crowdfunding()
            {
                Nom = Nom,
                MontantProjet = Montant,
                LieuProjet = LieuProjet,
                CategorieProjet = CategorieProjet,
                DateCreation = DateTime.Now,
                DateDebutProjet = DateDebut,
                DateFinProjet = DateFin,
                PorteurDuProjet = Porteur,
                Statut = true,
            };
            this._assoFlex.Crowdfundings.Add(crowdfundingToAdd);
            this._assoFlex.SaveChanges();
            return crowdfundingToAdd;
        }

        public void DeleteCrowdfunding(int Id)
        {
            Crowdfunding crowdfundingToDelete = this._assoFlex.Crowdfundings.Find(Id);
            this._assoFlex.Crowdfundings.Remove(crowdfundingToDelete);
            this._assoFlex.SaveChanges();
        }

        public Crowdfunding UpdateCrowdfunding(int Id, string Nom, int Montant, string LieuProjet, string CategorieProjet,
            DateTime DateFin)
        {
            Crowdfunding crowdfundingToUpdate = this._assoFlex.Crowdfundings.Find(Id);

            if (crowdfundingToUpdate != null)
            {


                crowdfundingToUpdate.Nom = Nom;
                crowdfundingToUpdate.MontantProjet = Montant;
                crowdfundingToUpdate.LieuProjet = LieuProjet;
                crowdfundingToUpdate.CategorieProjet = CategorieProjet;
                crowdfundingToUpdate.DateFinProjet = DateFin;

                this._assoFlex.Update(crowdfundingToUpdate);
                this._assoFlex.SaveChanges();
                

            }

            return crowdfundingToUpdate;

        }

        public List<Billetterie> getAllBilletteries()
        {
            throw new NotImplementedException();
        }

        public Billetterie getBilletterie(int Id)
        {
            throw new NotImplementedException();
        }

        public Billetterie CreateBilletterie(string Nom, string Prenom)
        {
            throw new NotImplementedException();
        }

        public void DeleteBilletterie(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBilletterie(int Id, string Nom, string Prenom)
        {
            throw new NotImplementedException();
        }

        public List<Evenement> getAllEvenements()
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ToList();
        }

        public Evenement getEvenement(int Id)
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ThenInclude(a=> a.AdminAsso).FirstOrDefault(e=>e.IdEvent==Id);
        }

        public EvenementViewModel getEvenementViewModel(int id)
        {
            Evenement eventToVM = _assoFlex.Evenements.Find(id);
            EvenementViewModel evm = new EvenementViewModel();
            evm.Evenements = eventToVM;
            return evm;
            
        }

        public Evenement CreateEvenement(Association organisateur, string nom, int nbTickets, DateTime DateDebut, DateTime DateFin,
            string Lieu, string categorie, int prix)
        {
            Evenement eventToAdd = new Evenement()
            {
                Organisateur = organisateur,
                NomEvent = nom,
                NbTickets = nbTickets,
                DateDebutEvent = DateDebut,
                DateFinEvent = DateFin,
                LieuEvent = Lieu,
                CategorieEvent = categorie,
                Prix = prix,
                Statut = true
            };
            this._assoFlex.Evenements.Add(eventToAdd);
            this._assoFlex.SaveChanges();
            return eventToAdd;
        }

        public void DeleteEvenement(int Id)
        {
            Evenement eventToDelete = this._assoFlex.Evenements.Find(Id);
            this._assoFlex.Evenements.Remove(eventToDelete);
            this._assoFlex.SaveChanges();
        }

        public Evenement UpdateEvenement(int Id, string nom, int nbTicket, DateTime DateDebut, DateTime DateFin,
            string Lieu, string categorie, int prix)
        {
            Evenement eventToUpdate = this._assoFlex.Evenements.Find(Id);
            if (eventToUpdate != null)
            {
                eventToUpdate.NomEvent = nom;
                eventToUpdate.NbTickets = nbTicket;
                eventToUpdate.DateDebutEvent = DateDebut;
                eventToUpdate.DateFinEvent = DateFin;
                eventToUpdate.LieuEvent = Lieu;
                eventToUpdate.CategorieEvent = categorie;
                eventToUpdate.Prix = prix;

                this._assoFlex.Update(eventToUpdate);
                this._assoFlex.SaveChanges();
            }

            return eventToUpdate;
        }
        

        }
    }
