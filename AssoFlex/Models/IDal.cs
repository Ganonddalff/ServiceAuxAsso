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
            int telephone, string email, string password, string role="Basic");
        void UpdateUtilisateur(int id, string prenom, string nom, string adresse,
            int telephone, string email, string password, string role);
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
        Souscription CreateSouscrition(int id, string formule);
        void UpdateSouscription();
        void DeleteSouscription(int id);

    }
}