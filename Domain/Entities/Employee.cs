
namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string EmployeeName { get; set; }
        public string Charge { get; set; }
        public DateOnly ContractingDate {get;set;}
        public ICollection<Sale> Sales { get; set; }
        
    }
}