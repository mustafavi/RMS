using System.ComponentModel.DataAnnotations.Schema;
namespace RMS.Data.ModelIM
{
    public enum ExpenseTypeIM
    {
    Water,
    Bills,
    Maintenance,

    }
    [Table("Expenses")]
    public class ExpenseIM
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public FlatIM FlatId { get; set; }
        public PropertyIM PropertyId { get; set; }
        public ExpenseTypeIM expenseType { get; set; }
        public DateTime dateSubmitted { get; set; }
        public string submittedBy { get; set; }
    }
}
