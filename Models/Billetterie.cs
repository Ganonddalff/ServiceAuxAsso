using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ServiceBilletterie.Models
{
    public partial class Billetterie
    
    {
        
        public short Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public short IdBillet { get; set; }
        public virtual Evenements IdBilletNavigation { get; set; }
    }
}
