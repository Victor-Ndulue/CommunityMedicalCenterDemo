using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace CMCDemo.Domain.Entities
{
    public class ProfessionalStaff
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "No field can be left vacant. Check and fill vacant spaces.")]
        [MaxLength(12, ErrorMessage ="First+ Name cannot be longer than 12 characters")]
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
        public DateTime DateJoinedCenter { get; set;}
        [Required]
        public DateTime DateLeftCenter { get; set;}
        [Required]
        public string? PhoneNumber { get; set; }

        [ForeignKey(nameof(StaffAddress))]
        public int StaffAddressId { get; set;}
        public virtual StaffAddress? StaffAddress { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

        [ForeignKey (nameof(Community_Medical_Centers))]
        public int Community_Medical_CentersId { get; set;}
        public virtual Community_Medical_Centers? Community_Medical_Centers { get; set; }

        public virtual ICollection<Ref_Disciplines>? Ref_Disciplines { get; set; }

    }
}