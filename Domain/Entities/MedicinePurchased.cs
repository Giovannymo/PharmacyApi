
namespace Domain.Entities;

    public class MedicinePurchased : BaseEntity
    {
        public double PriceBuy { get; set; }
        public int AmountBought { get; set; }
        public int IdBuy { get; set; }
        public Buy Buy { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        
    }
