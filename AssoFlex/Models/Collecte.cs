namespace AssoFlex.Models


{
    public class Collecte
    {
        public int Id { get; set; }
        
        public int MontantCollecte { get; set; }
        
        public int crowdfundingId { get; set; }
        
        public Crowdfunding crowdfunding { get; set; }
        
        
    }
}