using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Applications.DTO_s.DepartmentDTOS
{
    public class DepartmentForCreation
    {
        [Required(ErrorMessage = "Department name is required")]
        [MaxLength(20, ErrorMessage = "Department Name cannot exceed 20 charaacters")]
        public string? DepartmentName { get; set; }
        [MaxLength(20, ErrorMessage = "Department Chief name cannot exceed 20 charaacters")]
        public string? DepartmentChief { get; set; }
        [Required]
        public int Community_Medical_CentersId { get; set; }
        public Community_Medical_CentersForCreation? Community_Medical_Centers { get; set; }
    }
}
