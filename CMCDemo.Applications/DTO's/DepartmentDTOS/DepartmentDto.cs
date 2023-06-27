using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.DTO_s.DepartmentDTOS
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string? DepartmentName { get; set; }
        public string? DepartmentChief { get; set; }
        public int Community_Medical_CentersId { get; set; }
        public Community_Medical_Centers? MedicalCenter { get; set; }
        public ICollection<ProfessionalStaff>? ProfessionalStaff { get; set; }
    }
}
