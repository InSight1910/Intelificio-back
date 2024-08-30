using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Visit : BaseEntity
    {
        public string Name { get; set; }
        public string Rut { get; set; }
        public string Plate { get; set; }

    }
}
