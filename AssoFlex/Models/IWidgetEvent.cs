using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssoFlex.Models
{
    public interface IWidgetEvent
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
        [NotMapped]
        public ISubWidgetEvent SubWidgetEvent { get; set; }
    }
}