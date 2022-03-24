using Microsoft.EntityFrameworkCore;
using RMS.Data.Models2;

namespace RMS.Infrastructure.Repositories
{
    public class PropertyRepository : GenericRepository<Property>
    {

        public PropertyRepository(RMSContext context) : base(context)
        {
        }

        public override Property Get(Guid id)
        {
            var propertyId = context.Property
                .Include("Flats")
                .Where(p => p.PropertyId == id)
                .Select(p => p.PropertyId)
                .Single();
            return base.Get(propertyId);
        }

        public override IEnumerable<Property> GetAll()
        {
            var properties = context.Property.ToList();
            return properties;
        }



    }
}
