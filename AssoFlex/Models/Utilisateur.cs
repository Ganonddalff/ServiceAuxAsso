using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace AssoFlex.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Prenom { get; set; }
        [MaxLength(30)]
        public string Nom { get; set; }
        [MaxLength(80)]
        public string Adresse { get; set; }
        [MaxLength(15)]
        public int Telephone { get; set; }
        [MaxLength(50)]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string Email { get; set; }
       

        [MaxLength(100)]
        public string Password { get; set; }
        [MaxLength(12)]
        public string Role { get; set; }
        public byte[] ProfilImg { get; set; }
        // public List<Association> UserAssociations { get; set; }

    }
}
