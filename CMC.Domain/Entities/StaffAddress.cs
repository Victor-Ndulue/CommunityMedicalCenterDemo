using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Domain.Entities
{
    public class StaffAddress:CommonAddress
    {
        [Key]
        public int Id { get; set; }

        public ICollection <ProfessionalStaff>? ProfessionalStaff { get; set; }
    }
}