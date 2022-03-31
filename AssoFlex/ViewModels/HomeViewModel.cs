using System.Collections.Generic;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class HomeViewModel
    {
        public List<Association> Associations { get; set; }
        public Panier Panier { get; set; }
    }
}