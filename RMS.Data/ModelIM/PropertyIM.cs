using System.ComponentModel.DataAnnotations.Schema;
namespace RMS.Data.ModelIM
{
    [Table("Property")]
    public class PropertyIM
    {
        public int Id { get; set; }
        public string PropertyAddress { get; set; } 
        public string Description { get; set; } 
        public ICollection<FlatIM> Flat { get; set; } 
    }
}
