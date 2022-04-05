using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace AssoFlex.Models
{
    public class Dal : IDal
    {
        private const string AbsolutePath =
            "wwwroot/assets/";
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
            DefaultUsers.InitializeUsers();
            //------------- ASSOCIATIONS -------------//
            DefaultAssociations.InitializeAssocations();
            //------------- EVÈNEMENT -------------//
            DefaultEvents.InitializeEvents();
            //------------- CROWDFUNDING -------------//
            DefaultCrowdfunding.InitializeCrowdfunding();
            //------------- ADHESION ARTICLE -------------//
            this.CreateAdhesionArticle(
                this.GetAssociation(1),
                "1",
                0
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

        public string EncodeMD5(string motDePasse)
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
            string password, string profilImg, string role = "Basic")
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
            this.CreatePanier(userToAdd);
            this._assoFlex.SaveChanges();
            return userToAdd;
        }

        public void UpdateUtilisateur(int id, string prenom, string nom, string adresse, int telephone, string email,
            string password, string profilImg, string role)
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

        public Association GetAssociationByUserId(int id)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.AdminAssoId == id);
        }

        public int GetAssociationId(int idAdmin)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.AdminAssoId == idAdmin)!.Id;
        }

        public List<Association> GetAllAssociations()
        {
            return _assoFlex.Associations.Include(a => a.AdminAsso).ToList();
        }

        public List<IWidgetAsso> GetAssociationsToWidget()
        {
            
            List<Association> laListe = GetAllAssociations();
            var assoWidget = new List<IWidgetAsso>();
            foreach (var asso in laListe)
            {
                asso.SubWidgetAsso = new SubwidgetAsso
                {
                    Nom = asso.Nom,
                    Description = asso.Description
                };
                assoWidget.Add(asso);
            }
            return assoWidget;
        }

        public Association CreateAssociation(string nom, string numSiret, int idGerant, string logoAsso, string categorie,
            string description = "")
        {
            Association assoToAdd = new Association()
            {
                Nom = nom,
                NumSiret = numSiret,
                AssoLogo = logoAsso,
                DateInscription = DateTime.Now,
                CategorieAsso = categorie,
                Description = description,
                AdminAsso = this._assoFlex.Utilisateurs.Find(idGerant)
            };
            this._assoFlex.Associations.Add(assoToAdd);
            this._assoFlex.SaveChanges();
            return assoToAdd;
        }

        public void UpdateAssociation(int id, string nom, string numSiret, int idGerant, string logoAsso,
            string categorie, string description)
        {
            Association assoToUpdate = this._assoFlex.Associations.Find(id);
            if (assoToUpdate != null)
            {
                assoToUpdate.Nom = nom;
                assoToUpdate.NumSiret = numSiret;
                assoToUpdate.AdminAssoId = idGerant;
                assoToUpdate.AssoLogo = logoAsso;
                assoToUpdate.CategorieAsso = categorie;
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

        public Adhesion CreateAdhesion(int idAsso, int idUser, int adhesionArticleId)
        {
            AdhesionArticle adhesionArticle = this.GetAdhesionArticle(adhesionArticleId);
            DateTime dateFin;
            switch (Convert.ToInt16(adhesionArticle.Frequence))
            {
                case 1:
                    dateFin = DateTime.Now.AddMonths(1);
                    break;
                case 2:
                    dateFin = DateTime.Now.AddMonths(3);
                    break;
                case 3:
                    dateFin = DateTime.Now.AddMonths(6);
                    break;
                case 4:
                    dateFin = DateTime.Now.AddYears(1);
                    break;
                default:
                    dateFin = DateTime.Now.AddMonths(1);
                    break;
            }
            Adhesion adhesionToAdd = new Adhesion()
            {
                Association = this._assoFlex.Associations.Find(idAsso),
                Utilisateur = this._assoFlex.Utilisateurs.Find(idUser),
                DateDebut = DateTime.Now,
                DateFin = dateFin,
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

        #region AdhesionArticle

        public List<AdhesionArticle> GetAllAdhesionArticles()
        {
            return this._assoFlex.AdhesionArticles.ToList();
        }

        public ArticlePanier GetArticlePanier(int idArticle)
        {
            return this._assoFlex.ArticlesPanier.Find(idArticle);
        }

        public void DeleteArticlePanier(int idArticle, int idPanier)
        {
            List<ArticlePanier> articleFromPanier = this._assoFlex.ArticlesPanier.Where(a => a.PanierId == idPanier).ToList();
            ArticlePanier articleToDelete = articleFromPanier.FirstOrDefault(a => a.Id == idArticle);
            if (articleToDelete != null)
            {
                this._assoFlex.ArticlesPanier.Remove(articleToDelete);
                this._assoFlex.SaveChanges();
            }
        }

        public void UpdateArticlePanier(int idArticle, int quantite, int montant)
        {
            ArticlePanier articleToUpdate = this._assoFlex.ArticlesPanier.Find(idArticle);
            articleToUpdate.Quantite = quantite;
            articleToUpdate.MontantUnitaire = montant;
            this._assoFlex.SaveChanges();
        }

        public AdhesionArticle GetAdhesionArticle(int id)
        {
            return this._assoFlex.AdhesionArticles.Find(id);
        }

        public AdhesionArticle CreateAdhesionArticle(Association association,
            string frequence, double montant)
        {
            AdhesionArticle adhesionArticleToAdd = new AdhesionArticle()
            {
                Association = association,
                Nom = "Standard",
                Frequence = frequence,
                MontantAdh = montant
            };
            this._assoFlex.AdhesionArticles.Add(adhesionArticleToAdd);
            this._assoFlex.SaveChanges();
            return adhesionArticleToAdd;
        }

        public void UpdateAdhesionArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdhesionArticle(int id)
        {
            AdhesionArticle adhesionArticleToDelete = 
                this._assoFlex.AdhesionArticles.Find(id);
            this._assoFlex.AdhesionArticles.Remove(adhesionArticleToDelete);
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
            return this._assoFlex.Souscriptions.Find(id);
        }

        public Souscription CreateSouscrition(int id, string formule="Formule 1")
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
        
        public List<IWidgetCF> GetCrowdfundingsToWidget()
        {
            
            List<Crowdfunding> laListe = GetAllCrowdfundings();
            var cfWidget = new List<IWidgetCF>();
            foreach (var cf in laListe)
            {
                cf.SubWidgetCF = new ISubWidgetCF
                {
                    Nom = cf.Nom,
                    DateFinProjet = cf.DateFinProjet,
                    CategorieProjet = cf.CategorieProjet,
                    MontantProjet = cf.MontantProjet,
                    Collecte = cf.Collecte,
                    PorteurDuProjet = cf.PorteurDuProjet,
                    Description = cf.Description,
                };
                cfWidget.Add(cf);
            }
            return cfWidget;
        }
        
        public Crowdfunding CreateCrowdfunding(string nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateDebut,
            DateTime DateFin, Association Porteur, Collecte collecte, string imageCrowdfunding,string description)
        {
            Crowdfunding crowdfundingToAdd = new Crowdfunding()
            {
                Nom = nom,
                MontantProjet = Montant,
                LieuProjet = LieuProjet,
                CategorieProjet = CategorieProjet,
                DateCreation = DateTime.Now,
                DateDebutProjet = DateDebut,
                DateFinProjet = DateFin,
                PorteurDuProjet = Porteur,
                Collecte = collecte,
                Statut = true,
                ImageCrowdfunding = imageCrowdfunding,
                Description =description
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
            DateTime DateFin, string imageCrowdfunding,string description)
        {
            Crowdfunding crowdfundingToUpdate = this._assoFlex.Crowdfundings.Find(Id);

            if (crowdfundingToUpdate != null)
            {
                crowdfundingToUpdate.Nom = Nom;
                crowdfundingToUpdate.MontantProjet = Montant;
                crowdfundingToUpdate.LieuProjet = LieuProjet;
                crowdfundingToUpdate.CategorieProjet = CategorieProjet;
                crowdfundingToUpdate.DateFinProjet = DateFin;
                crowdfundingToUpdate.ImageCrowdfunding = imageCrowdfunding;
                crowdfundingToUpdate.Description = description;

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
        
        public List<IWidgetEvent> GetEventToWidget()
        {
            
            List<Evenement> laListe = GetAllEvenements();
            var eventWidget = new List<IWidgetEvent>();
            foreach (var eventInList in laListe)
            {
                eventInList.SubWidgetEvent = new SubWidgetEvent
                {
                    NomEvent = eventInList.NomEvent,
                    Description = eventInList.Description,
                    Prix = eventInList.Prix,
                    DateDebutEvent = eventInList.DateDebutEvent
                };
                eventWidget.Add(eventInList);
            }
            return eventWidget;
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
            string Lieu, string visuelEvent,string categorie, int prix, string description, string URL)
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
                VisuelEvent = visuelEvent,
                CategorieEvent = categorie,
                Prix = prix,
                Statut = true,
                Description = description,
                ytURL = URL.Replace("watch?v=","embed/")
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
            string Lieu, string visuelEvent,string categorie, int prix)
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

        #region LigneDeCommande

        public List<LigneDeCommande> GetAllLignesDeCommande()
        {
            return this._assoFlex.LignesDeCommande.ToList();
        }

        public LigneDeCommande GetLigneDeCommande(int id)
        {
            return this._assoFlex.LignesDeCommande.Find(id);
        }

        public LigneDeCommande CreateLigneDeCommande(int userId, decimal montantUnit, int quantite, string typeCommande)
        {
            LigneDeCommande ldcToAdd = new LigneDeCommande()
            {
                UtilisateurId = userId,
                MontantUnitaire = montantUnit,
                Quantite = quantite,
                TypeDeCommande = typeCommande
            };
            this._assoFlex.LignesDeCommande.Add(ldcToAdd);
            this._assoFlex.SaveChanges();
            return ldcToAdd;
        }

        public void UpdateLigneDeCommande(int id, int userId, decimal montantUnit, int quantite, string typeCommande)
        {
            LigneDeCommande ldcToUpdate = this._assoFlex.LignesDeCommande.Find(id);
            ldcToUpdate.UtilisateurId = userId;
            ldcToUpdate.MontantUnitaire = montantUnit;
            ldcToUpdate.Quantite = quantite;
            ldcToUpdate.TypeDeCommande = typeCommande;
            this._assoFlex.SaveChanges();
        }

        public void DeleteLigneDeCommande(int id)
        {
            LigneDeCommande ldcToDelete = this._assoFlex.LignesDeCommande.Find(id);
            this._assoFlex.LignesDeCommande.Remove(ldcToDelete);
            this._assoFlex.SaveChanges();
        }

        #endregion

        #region Commande

        public List<Commande> GetAllCommandes()
        {
            return this._assoFlex.Commandes.ToList();
        }

        public Commande GetCommande(int id)
        {
            return this._assoFlex.Commandes.FirstOrDefault(c => c.Id == id);
        }

        public Commande CreateCommande(int userId, int quantiteTotal, double sousTotal, double total,
            List<LigneDeCommande> lignesDeCommande)
        {
            Commande commandeToAdd = new Commande()
            {
                UtilisateurId = userId,
                DateCommande = DateTime.Now,
                QuantiteTotal = quantiteTotal,
                SousTotal = sousTotal,
                Total = total,
                LignesDeCommande = lignesDeCommande
            };
            this._assoFlex.Commandes.Add(commandeToAdd);
            this._assoFlex.SaveChanges();
            return commandeToAdd;
        }

        public void AddLigneCommandeToCommande(int id, LigneDeCommande ligneDeCommande)
        {
            Commande commandeToAddLdC = this._assoFlex.Commandes.Find(id);
            commandeToAddLdC.LignesDeCommande.Add(ligneDeCommande);
            this._assoFlex.SaveChanges();
        }

        public void UpdateCommande(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommande(int id)
        {
            Commande commandeToDelete = this._assoFlex.Commandes.Find(id);
            this._assoFlex.Commandes.Remove(commandeToDelete);
            this._assoFlex.SaveChanges();
        }
        
        #endregion

        #region Panier

        public List<Panier> GetAllPaniers()
        {
            return this._assoFlex.Paniers.ToList();
        }

        public Panier GetPanier(int id)
        {
            return this._assoFlex.Paniers.Find(id);
        }

        public Panier GetPanierByUserId(int userId)
        {
            var panier = this._assoFlex.Paniers.FirstOrDefault(p => p.UtilisateurId == userId);
            panier.Utilisateur = this.GetUtilisateur(userId);
            return panier;
        }

        public Panier GetPanierByUserId(string userIdStr)
        {
            return int.TryParse(userIdStr, out var id) ? this.GetPanierByUserId(id) : null;
        }

        public Panier CreatePanier(Utilisateur user)
        {
            Panier panierToAdd = new Panier()
            {
                Utilisateur = user,
                ArticlesPanier = new List<ArticlePanier>(),
            };
            this._assoFlex.Paniers.Add(panierToAdd);
            this._assoFlex.SaveChanges();
            return panierToAdd;
        }

        public void AddArticleToPanier(int id, ArticlePanier articlePanier)
        {
            Panier panier = this._assoFlex.Paniers.Find(id);
            if (panier.ArticlesPanier == null)
            {
                panier.ArticlesPanier = new List<ArticlePanier>();
            }
            panier.ArticlesPanier.Add(articlePanier);
            this._assoFlex.SaveChanges();
        }

        public void UpdatePanier(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePanier(int id)
        {
            Panier panierToDelete = this._assoFlex.Paniers.Find(id);
            this._assoFlex.Paniers.Remove(panierToDelete);
        }

        public List<ArticlePanier> GetArticlesPanierByPanierId(int panierId)
        {
            List<ArticlePanier> listeArticle = this._assoFlex.ArticlesPanier.Where(c => c.PanierId == panierId).ToList();
            return listeArticle;
        }

        #endregion
    }
}
