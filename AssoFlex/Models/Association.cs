using System;
using System.Collections.Generic;

namespace AssoFlex.Models
{
    public class Association
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumSiret { get; set; }
        public DateTime DateInscription { get; set; }
        public string Description { get; set; }
        // public Utilisateur AdminAsso { get; set; }
        // public List<Utilisateur> Adherent { get; set; }
    }
}