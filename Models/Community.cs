using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Community : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int MunicipalityId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
