using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AssoFlex.Models
{
    public class Billetterie
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Nom { get; set; }
        [MaxLength(25)]
        public string Prenom { get; set; }
        public int EvenementId { get; set; }
        public Evenement Evenement { get; set; }
        // public int IdBillet { get; set; }
        // public virtual Evenement IdBilletNavigation { get; set; }
    }
}
