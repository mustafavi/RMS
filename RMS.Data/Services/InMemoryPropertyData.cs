using RMS.Data.Models2;

namespace RMS.Data.Services
{
    public class InMemoryPropertyData : IPropertyData
    {
        List<Property> properties;


        public InMemoryPropertyData()
        {
            properties = new List<Property>()
            {
                //    new Property { Id = 1, Description = "40 Flats", PropertyAddress = "496 Wardend House, Washwood Heath Road, Birmingham, UK" },
                //    new Property { Id = 2, Description = "30 Flats", PropertyAddress = "33 South Street, Bristol, UK"},
                //    new Property { Id = 3, Description = "10 Flats", PropertyAddress = "21 Fenwick Place, London, UK"},
                //    new Property { Id = 4, Description = "20 Flats", PropertyAddress = "26 Howard Street, Bradford, UK"},
                //};

                new Property { PropertyId = new Guid("4bf23a32-6475-4e09-b3a2-3b514fb3e8ae"), Description = "40 Flats", PropertyAddress = "496 Wardend House, Washwood Heath Road, Birmingham, UK" },
                new Property { PropertyId = new Guid("167c38fb-f4d4-4e40-9c85-b6a235641502"), Description = "30 Flats", PropertyAddress = "33 South Street, Bristol, UK" },
                new Property { PropertyId = new Guid("a219df8d-ca45-4810-82b4-d34a1d520567"), Description = "10 Flats", PropertyAddress = "21 Fenwick Place, London, UK" },
                new Property { PropertyId = new Guid("0026864e-608a-4003-aec3-6fd05796fbe6"), Description = "20 Flats", PropertyAddress = "28 Howard Street, Bradford, UK" },
            };
        }
        public void Add(Property property)
        {
            properties.Add(property);
            property.PropertyId = properties.Max(p => p.PropertyId);
        }

        public void Delete(Guid id)
        {
            var record = Get(id);
            if (record != null)
            {
                properties.Remove(record);
            }
        }

        public Property Get(Guid id)
        {
            return properties.FirstOrDefault(r => r.PropertyId == id);
        }

        public IEnumerable<Property> GetAll()
        {
            return properties.OrderBy(p => p.PropertyAddress);
        }

        public void Update(Property property)
        {
            var existing = Get(property.PropertyId);
            if (existing != null)
            {
                existing.Description = property.Description;
                existing.PropertyAddress = property.PropertyAddress;
            }
        }
    }
}
