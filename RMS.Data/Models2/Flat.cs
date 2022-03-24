using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Models2
{
    [Table("Flat")]
    public class Flat 
    {
        public Guid FlatId { get; set; }
        public string FlatAddress { get; set; }
        public virtual Property Property { get; set; }
        public Guid PropertyId { get; set; }
        
        public Flat()
        {
            FlatId = Guid.NewGuid();
        }
    }
}
