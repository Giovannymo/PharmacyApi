
namespace Domain.Entities;

    public class Buy : BaseEntity
    {

        public DateTime DateBuy {get; set;}
        public int IdSupplier {get;set;}
        public ICollection<Supplier> Suppliers {get; set;}
        
    }
