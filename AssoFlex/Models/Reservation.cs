using Microsoft.AspNetCore.Routing.Matching;

namespace AssoFlex.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Utilisateur User { get; set; }
        public int EventId { get; set; }
        public Evenement Event { get; set; }
        public int NbTicket { get; set; }
    }
}