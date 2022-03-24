using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.ModelIM
{
    [Table("Rent")]
    public class RentIM
    {
        public int Id { get; set; }
        public decimal AdvancePaid { get; set; }
        public DateTime RentDue { get; set; }
        public DateTime RentPaid { get; set; }
        public decimal RentBalance { get; set; }
        public int TenantId { get; set; }
        public TenantIM Tenant { get; set; }
    }
}
