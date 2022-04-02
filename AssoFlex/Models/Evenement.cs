using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AssoFlex.Models
{
    public class Evenement : IWidgetEvent
    {
        [Key]
        public int IdEvent { get; set; }
        public int OrganisateurId { get; set; }
        [MaxLength(30)]
        public Association Organisateur { get; set; }
        [MaxLength(40)]
        public string NomEvent { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateDebutEvent { get; set; }
        public int NbTickets { get; set; }
        public int NbPlacesRestantes { get; set; }
        public string VisuelEvent { get; set; }
        public int Prix { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFinEvent { get; set; }
        [MaxLength(30)]
        public string LieuEvent { get; set; }
        public bool Statut { get; set; }
        [MaxLength(30)]
        public string CategorieEvent { get; set; }
        public string Description { get; set; }
        public string ytURL { get; set; }
        [NotMapped]
        public ISubWidgetEvent SubWidgetEvent { get; set; }
        
        // public virtual Billetterie Billetterie { get; set; }
    }

    public enum EventTypes 
    {
        Spectacle = 1,
        Conference = 2,
        Seminaire = 3,
        Manifestation = 4
    }
}
