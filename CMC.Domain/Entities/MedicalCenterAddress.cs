using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Domain.Entities
{
    public class MedicalCenterAddress : CommonAddress
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Community_Medical_Centers>? Community_Medical_Centers { get; set; }
    }
}
