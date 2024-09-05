using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class CommonSpace: BaseEntity
    {
        // falta ID_Comunidad
        public string Name { get; set; }
       
        public int Capacity { get; set; }
        public string AvailableHours { get; set; }

        public Community Community { get; set; }
    }
}
