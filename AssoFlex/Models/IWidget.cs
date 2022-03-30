using System;

namespace AssoFlex.Models
{
    public interface IWidget
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
        public ISubWidget SubWidget { get; set; }
    }
}