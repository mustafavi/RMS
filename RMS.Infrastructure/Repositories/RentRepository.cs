using RMS.Data.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repositories
{
    public class RentRepository : GenericRepository<Rent>
    {
        public RentRepository(RMSContext context):base(context)
        {

        }
    }
}
