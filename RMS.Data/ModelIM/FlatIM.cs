using System.ComponentModel.DataAnnotations.Schema;
namespace RMS.Data.ModelIM
{
    //==========================================>  ONE TO MANY RELATIONSHIP BETWEEN PROPERTY AND FLAT CLASSES 'A property can have one or many flats'
    [Table("Flat")]
    public class FlatIM //student 
    {
        public Guid Id { get; set; }
        public string FlatAddress { get; set; }
        public PropertyIM Property { get; set; }  
        public int PropertyId { get; set; }
        //  public virtual Property Property { get; set; }
        //  public int TenantId { get; set; }
        // public virtual Tenant Tenant { get; set; }

        public FlatIM()
        {
            Id = Guid.NewGuid();
        }
    }
}
