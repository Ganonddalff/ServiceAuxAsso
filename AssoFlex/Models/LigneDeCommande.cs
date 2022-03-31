namespace AssoFlex.Models
{
    public class LigneDeCommande
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int ProduitId { get; set; }
        public string ProduitNom { get; set; }
        public decimal MontantUnitaire { get; set; }
        public int Quantite { get; set; }
        public string TypeDeCommande {get; set;}
    }

    public enum TyeDeCommande
    {
        evenement = 1,
        crowdfunding = 2,
        adhesion = 3,
        souscription = 4
    }
}