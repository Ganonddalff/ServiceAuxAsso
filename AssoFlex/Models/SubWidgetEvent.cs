using System;
using System.ComponentModel.DataAnnotations;

namespace AssoFlex.Models
{
    public class SubWidgetEvent : ISubWidgetEvent
    {
        public string NomEvent { get; set; }
        public int Prix { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDebutEvent { get; set; }
    }
}