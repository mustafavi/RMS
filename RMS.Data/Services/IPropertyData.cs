using RMS.Data.Models2;
namespace RMS.Data.Services
{
    public  interface IPropertyData
    {
        IEnumerable<Property> GetAll();
        Property Get(Guid id);
        void Add(Property property);
        void Update(Property property);
        void Delete(Guid id);
    }
}
