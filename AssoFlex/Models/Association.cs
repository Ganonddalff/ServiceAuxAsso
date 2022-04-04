using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Association : IWidgetAsso
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string NumSiret { get; set; }
        public DateTime DateInscription { get; set; }
        public string Description { get; set; }
        public int AdminAssoId { get; set; }
        public Utilisateur AdminAsso { get; set; }
        public double MontantAdhesion { get; set; }
        public List<AdhesionArticle> AdhesionArticles { get; set; }
        public string RIB { get; set; }
        public string PieceIdentite { get; set; }
        public string PublieJO { get; set; }
        public string AssoHeaderImage { get; set; }
        public string AssoLogo { get; set; }
        [MaxLength(18)]
        public string CategorieAsso { get; set; }
        [NotMapped]
        public ISubWidgetAsso SubWidgetAsso { get; set; }
    }
    
    public enum CategoriesAsso
    {
        Humanitaire = 1,
        Sport = 2,
        Sociale = 3,
        Environnement = 4,
        Culture = 5,
        Santé = 6,
        Genre = 7,
        Réfugiés = 8,
        Education = 9,
        Agriculture = 10,
        Hydraulique = 11,
        Energie = 12,
        Jeunesse = 13,
    }
}