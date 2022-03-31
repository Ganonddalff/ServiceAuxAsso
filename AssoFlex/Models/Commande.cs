using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateCommande { get; set; }
        public int QuantiteTotal { get; set; }
        public double SousTotal { get; set; }
        public double Total { get; set; }
        public List<LigneDeCommande> LignesDeCommande { get; set; }
    }
}