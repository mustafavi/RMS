using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.Models2
{
    [Table("Rent")]
    public class Rent
    {
        public Guid RentId { get; set; }
        public decimal AdvancePaid { get; set; }
        public DateTime RentDue { get; set; }
        public DateTime RentPaid { get; set; }
        public decimal RentBalance { get; set; }

        public virtual Tenant Tenant { get; set; }
        public Guid TenantId { get; set; }
        


        public Rent()
        {
            RentId = Guid.NewGuid();
        }
    }
}
