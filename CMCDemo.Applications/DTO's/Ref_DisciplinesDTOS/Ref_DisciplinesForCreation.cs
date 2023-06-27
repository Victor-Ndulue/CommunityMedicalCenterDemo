using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS
{
    public class Ref_DisciplinesForCreation
    {

        [Required(ErrorMessage = "Discipline name cannot be left vacant")]
        public string? DisciplinesName { get; set; }
        [Required(ErrorMessage = "Discipline description cannot be left vacant")]
        public string? DisciplinesDescription { get; set; }
        [Required(ErrorMessage = "Date obtained discipline cannot be left vacant")]
        public DateTime? DateObtained { get; set; }

        public int ProfessionalStaffId { get; set; }
        public ProfessionalStaffForCreation? ProfessionalStaff { get; set; }

    }
}