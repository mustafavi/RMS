using RMS.Data.Models2;

namespace RMS.Infrastructure.Repositories
{
    public class TenantRepository : GenericRepository<Tenant>
    {
        public TenantRepository(RMSContext context) : base(context)
        {

        }
    }
}
