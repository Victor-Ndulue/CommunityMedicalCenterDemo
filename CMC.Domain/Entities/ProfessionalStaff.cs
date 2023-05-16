using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace CMCDemo.Domain.Entities
{
    public class ProfessionalStaff:AuditableBaseEntity
    {
        [ForeignKey(nameof(Ref_Disciplines))]
        public int Ref_Disciplines_Code { get; set;}
        [ForeignKey (nameof(Community_Medical_Centers))]
        public int MedicalCenter_Id { get; set;}
        [ForeignKey(nameof(StaffAddress))]
        public int StaffAddress_Id { get; set;}
        [ForeignKey(nameof(Department))]
        public int Department_Id { get; set; }

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
        public MailAddress? MailAddress { get; set;}
        [Required]
        public PhoneAttribute? PhoneNumber { get; set; }

        public StaffAddress? StaffAddress { get; set}
        public Community_Medical_Centers? MedicalCenter { get; set; }
        public Department? Department { get; set; }

        public ICollection<Ref_Disciplines>? Ref_Disciplines { get; set; }

    }
}