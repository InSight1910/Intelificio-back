using Intelificio_Back.Models.Base;
using Intelificio_Back.Models.Enums;

namespace Intelificio_Back.Models
{
    public class Package : BaseEntity
    {
        public string Notes { get; set; }
        public DateTime ReceptionDate { get; set; }
        public PackageStatus Status { get; set; }
    }

}
