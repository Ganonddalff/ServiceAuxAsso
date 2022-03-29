using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AssoFlex.Models
{
    public class Evenement
    {
        [Key]
        public int IdEvent { get; set; }
        public int OrganisateurId { get; set; }
        public Association Organisateur { get; set; }
        public string NomEvent { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateDebutEvent { get; set; }
        public int NbTickets { get; set; }
        public int NbPlacesRestantes { get; set; }
        
        public int Prix { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFinEvent { get; set; }
        public string LieuEvent { get; set; }
        public bool Statut { get; set; }
        public string CategorieEvent { get; set; }
        
        // public virtual Billetterie Billetterie { get; set; }
    }

    public enum EventTypes 
    {
Education = 1,
Sport = 2,
Humanitaire = 3,
Environnement = 4,
Culture = 5,
Santé = 6,
Spectacle = 7,
Conférence = 8,
Séminaire = 9

    }
    
    
}
