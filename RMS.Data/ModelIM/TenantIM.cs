using System.ComponentModel.DataAnnotations.Schema;
namespace RMS.Data.ModelIM
{
    [Table("Tenant")]
    public class TenantIM
    {
        public int Id { get; set; }
        public string TenantName { get; set; }
        public string NIC { get; set; }
        public DateTime ContractStarted { get; set; }
        public DateTime? ContractExpires { get; set; }
        public int TotalFamilyMembers { get; set; }
        public int? FlatId { get; set; }
        public FlatIM Flat { get; set; }
        public ICollection<RentIM> Rent { get; set; }
        public ICollection<BillIM> Bill { get; set; }
    }
}
