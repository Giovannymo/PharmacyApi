

namespace Domain.Entities;

    public class Medicine : BaseEntity
    {
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
        public ICollection<MedicineSold> MedicinesSold { get; set; }
        
    }
