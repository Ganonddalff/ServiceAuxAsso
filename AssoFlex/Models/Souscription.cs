using System;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Souscription
    {
        public int Id { get; set; }
        public int AssociationId { get; set; }
        public Association Association { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        [MaxLength(30)]
        public string Formule { get; set; }
        
    }
}