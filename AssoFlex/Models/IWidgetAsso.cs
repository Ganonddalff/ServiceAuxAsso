using System;

namespace AssoFlex.Models
{
    public interface IWidgetAsso
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumSiret { get; set; }
        public DateTime DateInscription { get; set; }
        public string Description { get; set; }
        public int AdminAssoId { get; set; }
        public Utilisateur AdminAsso { get; set; }
        public string AssoHeaderImage { get; set; }
        public string AssoLogo { get; set; }
        public string CategorieAsso { get; set; }
        public ISubWidgetAsso SubWidgetAsso { get; set; }
        
    }
}