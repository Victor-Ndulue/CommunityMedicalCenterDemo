using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS
{
    public class Ref_DisciplinesDto
    {
        public int Ref_DisciplinesId { get; set; }
        public int ProfessionalStaffId { get; set; }

        public string? DisciplinesName { get; set; }
        public string? DisciplinesDescription { get; set; }
        public DateTime? DateObtained { get; set; }

        public ProfessionalStaff? ProfessionalStaff { get; set; }
    }
}
