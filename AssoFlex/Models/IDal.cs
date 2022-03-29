using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssoFlex.ViewModels;

namespace AssoFlex.Models
{
    public interface IDal : IDisposable
    {
        void InitializeDb();
        
        // ************************************ //

        #region Utilisateur

        Utilisateur GetUtilisateur(int id);
        Utilisateur GetUtilisateur(string idStr);
        Utilisateur Authentifier(string email, string password);
        List<Utilisateur> GetAllUtilisateurs();
        Utilisateur CreateUtilisateur(string prenom, string nom, string adresse,
            int telephone, string email, string password, byte[] profilImg, string role="Basic");
        void UpdateUtilisateur(int id, string prenom, string nom, string adresse,
            int telephone, string email, string password, byte[] profilImg, string role);
        void DeleteUtilisateur(int id);

        #endregion
        
        // ****************************************** //

        #region Association

        Association GetAssociation(int id);
        Association GetAssociation(string idStr);
        int GetAssociationId(int idAdmin);
        List<Association> GetAllAssociations();
        Association CreateAssociation(string nom, string numSiret, int idGerant, byte[] logoAsso,
            string description="");
        void UpdateAssociation(int id, string nom, string numSiret, byte[] logoAsso,
            string description);
        void DeleteAssociation(int id);

        #endregion
        
        // ************************************ //

        #region Adhesion

        List<Adhesion> GetAllAdhesions();
        Adhesion CreateAdhesion(int idAsso, int idUser);
        void UpdateAdhesion();
        void DeleteAdhesion(int id);

        #endregion

        // ************************************ //

        #region Souscription

        List<Souscription> GetAllSouscriptions();
        Souscription GetSouscription(int id);
        Souscription CreateSouscrition(int id, string formule);
        void UpdateSouscription();
        void DeleteSouscription(int id);

        #endregion
        
        // ******************************** //

        #region Crowdfunding

        List<Crowdfunding> GetAllCrowdfundings();
        Crowdfunding GetCrowdfunding(int id);
        Crowdfunding GetCfCollecte(int id);
        Crowdfunding CreateCrowdfunding(string nom, int montant, string lieuProjet, string categorieProjet,
            DateTime dateDebut, DateTime dateFin, Association porteurDuProjet, Collecte collecte);
        Crowdfunding UpdateCrowdfunding(int id, string nom, int montant, string lieuProjet, 
            string categorieProjet, DateTime dateFin);
        void DeleteCrowdfunding(int id);
        
        #endregion
        
        // ******************************** //

        #region Collecte

        List<Collecte> GetAllCollectes();
        Collecte GetCollecte(int id);
        Collecte CreateCollecte();
        void UpdateCollecte();
        void DeleteCollecte(int id);

        #endregion
        
        // ******************************** //

        #region Contribution

        List<Contribution> GetAllContributions();
        Contribution GetAllContribution(int id);
        Contribution CreateContribution(double montantContribution, int collecteId, Utilisateur userLoggedIn);
        void UpdateContribution(int id, double montantContribution, int collecteId, Utilisateur userLoggedIn);
        void DeleteContribution(int id);

        #endregion

        // ******************************** //

        #region Billetterie

        List<Billetterie> GetAllBilletteries();
        Billetterie GetBilletterie(int id);
        Billetterie CreateBilletterie(string nom, string prenom);
        void DeleteBilletterie(int id);
        void UpdateBilletterie(int id, string nom, string prenom);

        #endregion
        
        // ******************************** //

        #region Evenement

        List<Evenement> GetAllEvenements();
        Evenement GetEvenement(int id);
        EvenementViewModel GetEvenementViewModel(int id);
        Evenement CreateEvenement(Association organisateur, string nom, int nbTickets, 
            DateTime dateDebut, DateTime dateFin, string lieu, string categorie, int prix);
        void DeleteEvenement(int id);
        Evenement UpdateEvenement(int id, string nom, int nbTicket, 
            DateTime dateDebut, DateTime dateFin, string lieu, string categorie, int prix);

        #endregion
       
    }
}