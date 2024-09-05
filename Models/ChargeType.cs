using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class ChargeType: BaseEntity
    {
        public string Description { get; set; }

        public IEnumerable<Charge> Charges { get; set; }
    }
}
