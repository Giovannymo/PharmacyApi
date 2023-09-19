
namespace Domain.Entities;

    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public int IdPatientFk { get; set; }
        public Patient Patient { get; set; }
    }
