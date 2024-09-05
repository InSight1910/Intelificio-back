using Intelificio_Back.Models.Base;

namespace Intelificio_Back.Models
{
    public class Building : BaseEntity
    {
        public string Name { get; set; }
        //public int CommunityId { get; set; }
        public bool IsActive { get; set; }
        public Community Community { get; set; }
    }
}
