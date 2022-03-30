using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AssoFlex.Models
{
    public class Association : IWidget
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumSiret { get; set; }
        public DateTime DateInscription { get; set; }
        public string Description { get; set; }
        public int AdminAssoId { get; set; }
        public Utilisateur AdminAsso { get; set; }
        public byte[] AssoHeaderImage { get; set; }
        public byte[] AssoLogo { get; set; }
        [NotMapped]
        public ISubWidget SubWidget { get; set; }
    }
}