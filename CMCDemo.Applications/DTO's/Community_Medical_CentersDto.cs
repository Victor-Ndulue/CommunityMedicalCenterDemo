using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.DTO_s
{
    public class Community_Medical_CentersDto
    {
        public int Id { get; set; }
        public string? MedicalCenterName { get; set; }
        public string? MedicalCenterManager { get; set; }
        public string? PhoneNumber { get; set; }
        public MedicalCenterAddress? MedicalCenterAddress { get; set; }

        public ICollection<Department>? Departments { get; set; }
        public ICollection<ProfessionalStaff>? Staffs { get; set; }
    }
}
