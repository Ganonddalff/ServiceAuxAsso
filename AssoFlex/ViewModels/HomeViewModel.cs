using System.Collections.Generic;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class HomeViewModel
    {
        public List<Association> Associations { get; set; }
        public List<Evenement> Evenements  { get; set; }
        public List<Crowdfunding> Crowdfunding { get; internal set; }
    }
}
   







