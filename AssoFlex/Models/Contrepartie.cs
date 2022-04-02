using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class Contrepartie
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string TypeContrepartie { get; set; }

    }
}
