using RMS.Data.Models2;

namespace RMS.Web.ViewModel
{
    public class PropertyModel
    {
        public string PropertyAddress { get; set; }
        public string Description { get; set; }
        public IEnumerable<Flat> Flats { get; set; }
    }
}
