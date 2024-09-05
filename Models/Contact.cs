using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Service { get; set; }
        public Community Community { get; set; }
    }
}
