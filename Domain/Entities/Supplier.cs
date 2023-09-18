
namespace Domain.Entities;

    public class Supplier : BaseEntity
    {
        public string NameSupplier { get; set; }  
        public string ContactSupplier {get; set;}
        public Address Address {get;set;}

    }