using AssoFlex.Models;

namespace AssoFlex.ViewModels
{
    public class CheckoutViewModel
    {
        public decimal ReducPourcent { get; set; }
        public string ReducNom { get; set; }

        public int QuantiteTotalArticle { get; set; }
        public decimal MontantAvcReduc { get; set; }
        public decimal SousTotal { get; set; }
        public decimal Total { get; set; }
        
    }
}