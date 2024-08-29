using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class CommonSpace: BaseEntity
    {
        // falta ID_Comunidad
        public string name { get; set; }
       
        public int capacity { get; set; }
        public string availableHours { get; set; }

    }
}
