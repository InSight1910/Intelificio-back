using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Payment : BaseEntity
    {
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public string URL { get; set; }
    }
}
