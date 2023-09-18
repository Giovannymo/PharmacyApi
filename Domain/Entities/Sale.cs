namespace Domain.Entities;

    public class Sale : BaseEntity
    {
        public DateOnly SaleDate {get; set;}
        public int IdPatientFk {get; set;}
        public Patient Patient {get; set;}
        public int IdEmployeeFk {get; set;}
        public Employee Employee {get; set;}
    
    
    }
