using RMS.Data.Models2;

namespace RMS.Infrastructure.Repositories
{
    public class ExpenseRepository : GenericRepository<Expense>
    {
        public ExpenseRepository(RMSContext context): base(context)
        {

        }
    }
}
