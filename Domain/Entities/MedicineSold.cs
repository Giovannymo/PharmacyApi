
namespace Domain.Entities
{
    public class MedicineSold : BaseEntity
    {
        public int IdSaleFk {get;set;}
        public Sale Sale {get;set;}
        public int IdMedicineFk {get;set;}
        public Medicine Medicine {get;set;}
        public string AmountSold {get;set;}
        public double Price {get;set;}
    }
}