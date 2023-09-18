
namespace Domain.Entities;

    public class Patient : BaseEntity 
    {
        public string PatientName {get;set;}
        public string PhoneNumber {get;set;}
        public Address Address {get;set;}
        public ICollection<Sale> Sales { get; set; }
        
    }

