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
        private const string AbsolutePath =    "./wwwroot/assets/";
        //private const string DefaultAvatar = "../wwwroot/assets/img/avatar.jpeg";
        private AssoFlexContext _assoFlex;

        public Dal()
        {
            this._assoFlex = new AssoFlexContext();
        }
        
        public void Dispose()
        {
           this._assoFlex.Dispose();
        }

        public byte[] ImageToByteArray(string pathImage) //Image image
        {
            return System.IO.File.ReadAllBytes(pathImage);
        }

        #region Initialisation
        public void InitializeDb()
        {
            this._assoFlex.Database.EnsureDeleted();
            this._assoFlex.Database.EnsureCreated();

            //------------- UTILISATEURS -------------//
            this.CreateUtilisateur(
                "Guytri",
                "Kastane",
                "31 rue de l'aurore",
                0755172316,
                "gkastane@gmail.com",
                EncodeMD5("11111"),
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin");
            this.CreateUtilisateur(
                "Mateusz",
                "Tirel",
                "19, rue des petites murailles",
                0667127014,
                "admin",
                EncodeMD5("admin"),
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin");
            this.CreateUtilisateur(
                "Billal",
                "Benziane",
                "32 rue de l'aurore",
                0755172317,
                "billal.benziane1@gmail.com",
                EncodeMD5("11111"), 
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin");
            this.CreateUtilisateur(
                "Paul",
                "Jean",
                "78 rue de l'aurore",
                0755172320,
                "pjean@gmail.com",
                EncodeMD5("22222"), 
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin-Asso");
            this.CreateUtilisateur(
                "Jean",
                "Jacques",
                "",
                0755172324,
                "jjacques@gmail.com", 
                EncodeMD5("33333"), 
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin-Asso");
            this.CreateUtilisateur(
                "Jessica",
                "Alba", 
                "",
                0755172328,
                "jalba@gmail.com",
                EncodeMD5("44444"), 
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"),"Admin-Asso");
            this.CreateUtilisateur(
                "Louis",
                "David",
                "",
                0755172332,
                "ldavid@gmail.com",
                EncodeMD5("55555"),
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"));
            this.CreateUtilisateur(
                "Alban",
                "Ivanoff",
                "",
                0755172338,
                "aivanoff@gmail.com",
                EncodeMD5("66666"),
                ImageToByteArray(AbsolutePath + "img/avatar.jpeg"));
            
            //------------- ASSOCIATIONS -------------//
            this.CreateAssociation(
                "AGP",
                "111111-111",
                2,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "13",
                "Association des Gabonais de Poitiers");
            this.CreateAssociation(
                "ASTEC",
                "222222-222",
                3,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "5",
                "L'Association pour la Science et la " +
                "Transmission de l'Esprit Critique a pour principal" +
                " projet la chaîne YouTube la Tronche en Biais."
                );
            this.CreateAssociation(
                "Tête en l'air",
                "333333-333",
                4,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "2",
                "Depuis 2006, nous avons pour objectif de faire partager à un large public notre passion. " +
                "A ce titre, nos membres se déplacent avec leur matériel dans les écoles, centres de loisirs, associations," +
                " soirées privées etc."
                );
            
            //------------- EVÈNEMENT -------------//
            this.CreateEvenement(
                this.GetAssociation(1),
                "Eminem", 
                50, 
                new DateTime(2022, 12, 30), 
                new DateTime(2022, 12, 30), 
                "ACCORD ARENA", 
                "5",
                90);
            this.CreateEvenement(
                this.GetAssociation(1),
                "PNL",
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                10);
            this.CreateEvenement(
                this.GetAssociation(3),
                "Eminem", 
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                100);
            this.CreateEvenement(
                this.GetAssociation(2),
                "Concert super",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Paris",
                "1",
                5);
            
            //------------- CROWDFUNDING -------------//
            this.CreateCrowdfunding(
                "Jackson",
                10000,
                "Montreuil",
                "1", 
                new DateTime(2022, 04, 22),
                new DateTime(2023, 04, 21),
                this.GetAssociation(1), 
                this.CreateCollecte()
                );
            this.CreateCrowdfunding(
                "Jefferson",
                30000,
                "Dallas", 
                "2",
                new DateTime(2022, 06, 27),
                new DateTime(2023, 05, 30),
                this.GetAssociation(3),
                this.CreateCollecte()
                );
            this.CreateCrowdfunding(
                "Nguyen",
                80000,
                "Vietnam",
                "3",
                new DateTime(2022, 09, 22),
                new DateTime(2023, 05, 01),
                this.GetAssociation(2),
                this.CreateCollecte()
                );
            this.CreateCrowdfunding(
                "Benjamin",
                450000,
                "Montpellier",
                "Construction",
                new DateTime(2022, 12, 24),
                new DateTime(2023, 11, 21),
                this.GetAssociation(1),
                this.CreateCollecte()
                );
        }
        #endregion

        #region Utilisateur

        public Utilisateur GetUtilisateur(int id)
        {
            return this._assoFlex.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public Utilisateur GetUtilisateur(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.GetUtilisateur(id) : null;
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

        public List<Utilisateur> GetAllUtilisateurs()
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

        #endregion

        #region Association

        public Association GetAssociation(int id)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.Id == id);
        }

        public Association GetAssociation(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.GetAssociation(id) : null;
        }

        public int GetAssociationId(int idAdmin)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.AdminAssoId == idAdmin)!.Id;
        }

        public List<Association> GetAllAssociations()
        {
            return _assoFlex.Associations.ToList();
        }

        public Association CreateAssociation(string nom, string numSiret, int idGerant, byte[] logoAsso, string categorie, string description = "")
        {
            Association assoToAdd = new Association()
            {
                Nom = nom,
                NumSiret = numSiret,
                DateInscription = DateTime.Now,
                Description = description,
                AdminAsso = this._assoFlex.Utilisateurs.Find(idGerant),
                CategorieAsso = categorie
            };
            this._assoFlex.Associations.Add(assoToAdd);
            this._assoFlex.SaveChanges();
            return assoToAdd;
        }

        public void UpdateAssociation(int id, string nom, string numSiret, byte[] logoAsso, string description)
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

        #endregion

        #region Adhesion

        public List<Adhesion> GetAllAdhesions()
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

        #endregion

        #region Souscription

        public List<Souscription> GetAllSouscriptions()
        {
            return this._assoFlex.Souscriptions.ToList();
        }

        public Souscription GetSouscription(int id)
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

        #endregion

        #region Crowdfunding

        public Crowdfunding GetCrowdfunding(int id)
        {
            return _assoFlex.Crowdfundings.Include(c => c.PorteurDuProjet).ThenInclude(e => e.AdminAsso).FirstOrDefault(a => a.Id==id);
        }

        public Crowdfunding GetCfCollecte(int id)
        {
            return _assoFlex.Crowdfundings.Include(c => c.Collecte).FirstOrDefault(a => a.Id == id);
        }
        
        public List<Crowdfunding> GetAllCrowdfundings()
        {
            return _assoFlex.Crowdfundings.Include(c =>c.Collecte).ToList();
        }

        public Crowdfunding CreateCrowdfunding(string Nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateDebut,
            DateTime DateFin, Association Porteur, Collecte collecte)
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
                Collecte = collecte,
                Statut = true,
            };
            this._assoFlex.Crowdfundings.Add(crowdfundingToAdd);
            this._assoFlex.SaveChanges();
            return crowdfundingToAdd;
        }

        public void DeleteCrowdfunding(int id)
        {
            Crowdfunding crowdfundingToDelete = this._assoFlex.Crowdfundings.Find(id);
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
        
        #endregion

        #region Collecte

        public List<Collecte> GetAllCollectes()
        {
            throw new NotImplementedException();
        }

        public Collecte GetCollecte(int id)
        {
            return _assoFlex.Collectes.Find(id);
        }
        public Collecte CreateCollecte()
        {
            Collecte maCollecte = new Collecte()
            {
                MontantCollecte = 0,
            };
            _assoFlex.Add(maCollecte);
            _assoFlex.SaveChanges();
            return maCollecte;
        }

        public void UpdateCollecte()
        {
            throw new NotImplementedException();
        }

        public void DeleteCollecte(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Contribution

        public List<Contribution> GetAllContributions()
        {
            throw new NotImplementedException();
        }

        public Contribution GetAllContribution(int id)
        {
            throw new NotImplementedException();
        }
        
        public Contribution CreateContribution(double montantContribution, int collecteId, Utilisateur userLoggedIn)
        {
            Collecte maCollecte = GetCollecte(collecteId);
            Contribution maContribution = new Contribution()
            {
                MontantContribution = montantContribution,
                collecte = maCollecte,
                DateContribution = DateTime.Now,
                utilisateur = userLoggedIn,

            };

            maCollecte.MontantCollecte = (maCollecte.MontantCollecte + montantContribution);
            _assoFlex.Update(maCollecte);
            _assoFlex.Add(maContribution);
            _assoFlex.SaveChanges();
            return maContribution;
        }

        public void UpdateContribution(int id, double montantContribution, int collecteId, Utilisateur userLoggedIn)
        {
            throw new NotImplementedException();
        }

        public void DeleteContribution(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Billetterie

        public List<Billetterie> GetAllBilletteries()
        {
            throw new NotImplementedException();
        }

        public Billetterie GetBilletterie(int id)
        {
            throw new NotImplementedException();
        }

        public Billetterie CreateBilletterie(string nom, string prenom)
        {
            throw new NotImplementedException();
        }

        public void DeleteBilletterie(int id)
        {
            throw new NotImplementedException();
        }
        
        public void UpdateBilletterie(int id, string nom, string prenom)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Evenement

        public List<Evenement> GetAllEvenements()
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ToList();
        }

        public Evenement GetEvenement(int id)
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ThenInclude(a=> a.AdminAsso).FirstOrDefault(e=>e.IdEvent==id);
        }

        public EvenementViewModel GetEvenementViewModel(int id)
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
                NbPlacesRestantes = nbTickets,
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

        #endregion

    }
}
