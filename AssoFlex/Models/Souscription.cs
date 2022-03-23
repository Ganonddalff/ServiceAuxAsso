using System;

namespace AssoFlex.Models
{
    public class Souscription
    {
        public int Id { get; set; }
        public int AssociationId { get; set; }
        public Association Association { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Formule { get; set; }
        
    }
}