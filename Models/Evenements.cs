using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ServiceBilletterie.Models
{
    public class Evenements
    {
        public short IdEvent { get; set; }
        public string Organisateur { get; set; }
        public string NomEvent { get; set; }
        public DateTime? DateDebutEvent { get; set; }
        public long NbTickets { get; set; }
        public DateTime? DateFinEvent { get; set; }
        public string LieuEvent { get; set; }
        public bool? Statut { get; set; }
        public string CategorieEvent { get; set; }

        public virtual Billetterie Billetterie { get; set; }
    }
}
