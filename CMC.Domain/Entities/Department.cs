using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMCDemo.Domain.Entities
{
    public class Department
    {
        [Key] 
        public int Id { get; set; }

        [ForeignKey(nameof(Community_Medical_Centers))]
        public int MedicalCenter_Id { get; set; }

        [Required]
        public string? DepartmentName { get; set; }
        public string? DepartmentChief { get; set; }

        public virtual Community_Medical_Centers? MedicalCenter { get; set; }
        public virtual  ICollection<ProfessionalStaff>? ProfessionalStaff { get; set; }
    }
}