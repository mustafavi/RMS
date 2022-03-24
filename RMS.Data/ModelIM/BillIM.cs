using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.ModelIM
{
    [Table("Bill")]
    public class BillIM
    {
        public int  Id { get; set; }
        public string Description { get; set; }
        public DateTime? BillDueDate { get; set; }
        public DateTime? BillPaidDate { get; set; }
        public Char BillType { get; set; }
        public int TenantId { get; set; }
        public TenantIM Tenant { get; set; }

      
    }
}
