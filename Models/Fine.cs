using Intelificio_Back.Models.Base;
using Intelificio_Back.Models.Enums;
namespace Intelificio_Back.Models

{
    public class Fine : BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public FineDenomination Status { get; set; }

    }
}
