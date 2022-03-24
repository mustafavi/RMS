using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.Models2
{
    [Table("Tenant")]
    public class Tenant
    {
        public Guid Id { get; set; }
        public string TenantName { get; set; }
        public string NIC { get; set; }
        public DateTime ContractStarted { get; set; }
        public DateTime? ContractExpires { get; set; }
        public int TotalFamilyMembers { get; set; }
        public Guid FlatId { get; set; }
        public Flat Flat { get; set; }
        public ICollection<Rent> Rent { get; set; }
        public ICollection<Bill> Bill { get; set; }

        public Tenant()
        {
            Id = Guid.NewGuid();
        }
    }
}
