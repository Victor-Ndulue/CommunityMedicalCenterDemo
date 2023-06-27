using CMCDemo.Applications.DTO_s.DepartmentDTOS;
using CMCDemo.Applications.DTO_s.StaffAddressDTOS;
using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS
{
    public class ProfessionalStaffForCreation
    {

        public int Community_Medical_CentersId { get; set; }
        public int StaffAddressId { get; set; }
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "No field can be left vacant. Check and fill vacant spaces.")]
        [MaxLength(12, ErrorMessage = "First+ Name cannot be longer than 12 characters")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "No field can be left vacant. Check and fill vacant spaces.")]
        [MaxLength(12, ErrorMessage = "Last name cannot be longer than 12 characters")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "No field can be left vacant. Check and fill vacant spaces.")]
        [MaxLength(6, ErrorMessage = "Gender cannot be longer than 12 characters")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "No field can be left vacant. Check and fill vacant spaces.")]
        public DateTime DateBirthed { get; set; }
        [Required]
        public DateTime DateJoinedCenter { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public StaffAddressForCreation? StaffAddress { get; set; }
        public DepartmentForCreation? Department { get; set; }
        public Community_Medical_CentersForCreation? Community_Medical_Centers { get; set; }

    }
}
