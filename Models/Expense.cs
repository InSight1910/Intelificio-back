using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Expense : BaseEntity
    {
        // Falta ID_Comunidad
        // Falta ID_Tipo_Gasto
        public int amount {  get; set; }
        public DateTime date { get; set; }

        public ExpenseType Type { get; set; } 
        
        public Community Community { get; set; }
    }
}
