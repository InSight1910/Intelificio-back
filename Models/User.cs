using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class User : BaseEntity
    {
       // public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Password { get; set; }
        //public string NationalId { get; set; }
        public DateTime BirthDate { get; set; }
        //public UserRole Role { get; set; }
    }
}
