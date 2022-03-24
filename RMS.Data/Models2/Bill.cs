using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.Models2
{
    public enum BillType
    { 
    Electricity,
    Gas,
    Water
    }

    [Table("Bill")]
    public class Bill
    {
        public Guid BillId { get; set; }
        public string Description { get; set; }
        public DateTime? BillDueDate { get; set; }
        public DateTime? BillPaidDate { get; set; }
        public BillType? BillType { get; set; }
        
        public virtual Tenant Tenant { get; set; }
        public Guid TenantId { get; set; }
        

        public Bill()
        {
            BillId = Guid.NewGuid();
        }
    }
}
