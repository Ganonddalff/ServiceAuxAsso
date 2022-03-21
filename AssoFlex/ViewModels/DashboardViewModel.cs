using System.Collections.Generic;
using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class DashboardViewModel
    {
        public List<Utilisateur> Utilisateurs{ get; set; }
        public List<Association> Associations { get; set; }
    }
}