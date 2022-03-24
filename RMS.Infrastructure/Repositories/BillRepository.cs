using RMS.Data.Models2;

namespace RMS.Infrastructure.Repositories
{
    public class BillRepository : GenericRepository<Bill>
    {
        public BillRepository(RMSContext context) : base(context)
        {
            
        }

        public override Bill Get(Guid id)
        {
            var billId = context.Bill
                .Where(b => b.BillId == id)
                .Select(b => b.BillId)
                .Single();
            return base.Get(billId);
        }
    }
}
