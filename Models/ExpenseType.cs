using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class ExpenseType : BaseEntity
    {
        public string Description { get; set; }

        public IEnumerable<Expense> Expenses { get; set; }
    }
}
