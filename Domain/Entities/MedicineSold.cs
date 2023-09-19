
namespace Domain.Entities
{
    public class MedicineSold : BaseEntity
    {
        public int IdSaleFk {get;set;}
        public Sale Sale {get;set;}
        public int IdMedicineFk {get;set;}
        public Medicine Medicine {get;set;}
        public decimal AmountSold {get;set;}
        public decimal Price {get;set;}
    }
}