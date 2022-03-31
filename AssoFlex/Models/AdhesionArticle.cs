namespace AssoFlex.Models
{
    public class AdhesionArticle
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int AssociationId { get; set; }
        public Association Association { get; set; }
        public decimal MontantAdh { get; set; }
        public string  Frequence { get; set; }
        
    }
    
    public enum CategorieAdhesion 
    {
        mensuelle = 1,
        trimestrielle = 2,
        semestrielle = 3,
        annuelle = 4
    }
}