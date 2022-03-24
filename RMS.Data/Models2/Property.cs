using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Data.Models2
{
    [Table("Property")]
    public class Property
    {
        public Guid PropertyId { get; set; }
        public string PropertyAddress { get; set; }
        public string Description { get; set; }
        public ICollection<Flat> Flats { get; set; }        
       


        public Property()
        {
            PropertyId = Guid.NewGuid();
            PropertyAddress = string.Empty;
            Description = string.Empty;
            Flats = new List<Flat>();
            
        }

    }
}
