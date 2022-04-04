namespace AssoFlex.Models
{
    public class ArticlePanier
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int ProduitId { get; set; }
        public string ProduitNom { get; set; }
        public double MontantUnitaire { get; set; }
        public int Quantite { get; set; }
        public string TypeDeCommande {get; set;}
        public int PanierId { get; set; }
        public Panier Panier { get; set; }
    }
}