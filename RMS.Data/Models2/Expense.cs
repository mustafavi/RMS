using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Models2
{
    public enum ExpenseType
    {
        Water,
        Bills,
        Maintenance,

    }
    [Table("Expense")]
    public class Expense
    {
        public Guid ExpenseId { get; set; }
        public string Description { get; set; }
        public ExpenseType expenseType { get; set; }
        public DateTime dateSubmitted { get; set; }
        public string submittedBy { get; set; }


        public virtual Flat Flat { get; set; }
        public Guid FlatId { get; set; }
       // public virtual Property Property { get; set; }
       // public Guid PropertyId { get; set; }


        public Expense()
        {
            ExpenseId = Guid.NewGuid();
        }
    }
}
