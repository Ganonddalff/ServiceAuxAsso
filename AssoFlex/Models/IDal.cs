using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public interface IDal : IDisposable
    {
        void InitializeDb();
        Utilisateur getUtilisateur(int id);
        Utilisateur getUtilisateur(string idStr);
        Utilisateur Authentifier(string email, string password);
        List<Utilisateur> getAllUtilisateurs();
        Utilisateur CreateUtilisateur(string prenom, string nom, string adresse,
            int telephone, string email, string password, byte[] profilImg, string role="Basic");
        void UpdateUtilisateur(int id, string prenom, string nom, string adresse,
            int telephone, string email, string password, byte[] profilImg, string role);
        void DeleteUtilisateur(int id);
        
        // ****************************************** //
        Association getAssociation(int id);
        Association getAssociation(string idStr);
        List<Association> getAllAssociations();
        Association CreateAssociation(string nom, string numSiret, int idGerant,
             string description="");
        void UpdateAssociation(int id, string nom, string numSiret,
             string description);
        void DeleteAssociation(int id);
        
        // ************************************ //
        List<Adhesion> getAllAdhesions();
        Adhesion CreateAdhesion(int idAsso, int idUser);
        void UpdateAdhesion();
        void DeleteAdhesion(int id);
        
        // ************************************ //
        List<Souscription> getAllSouscriptions();
        Souscription getSouscription(int id);
        Souscription CreateSouscrition(int id, string formule);
        void UpdateSouscription();
        void DeleteSouscription(int id);
        
        // ******************************** //
        List<Crowdfunding> getAllCrowdfundings();
        Crowdfunding getCrowdfunding(int Id);
        Crowdfunding CreateCrowdfunding(string Nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateDebut, DateTime DateFin);
        void DeleteCrowdfunding(int Id);
        void UpdateCrowdfunding(int Id, string Nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateFin);
        
        // ******************************** //
        List<Billetterie> getAllBilletteries();
        Billetterie getBilletterie(int Id);
        Billetterie CreateBilletterie(string Nom, string Prenom);
        void DeleteBilletterie(int Id);
        void UpdateBilletterie(int Id, string Nom, string Prenom);
        
        // ******************************** //
        List<Evenement> getAllEvenements();
        Evenement getEvenement(int Id);
        Evenement CreateEvenement(int organisateurId, string nom, int nbTickets, 
            DateTime DateDebut, DateTime DateFin, string Lieu, string categorie);
        void DeleteEvenement(int Id);
        void UpdateEvenement(int Id, string nom, int nbTicket, 
            DateTime DateDebut, DateTime DateFin, string Lieu, string categorie);
    }
}