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
        public IEnumerable<CommonSpace> Spaces { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }
        public IEnumerable<Charge> Charges { get; set; }
        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Maintenance> Maintenances { get; set; }
    }
}
