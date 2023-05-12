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

        public string? FirstName { get; set;}
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateBirthed { get; set; }
        public DateTime DateJoinedCenter { get; set;}
        public DateTime DateLeftCenter { get; set;}
        public MailAddress? MailAddress { get; set;}
        public PhoneAttribute? PhoneNumber { get; set; }
        public Ref_Disciplines? Ref_Discipline { get; set;}
        public StaffAddress? StaffAddress { get; set;}
        public Community_Medical_Centers? MedicalCenter { get; set;}
        public Department? Department { get; set; }
    }
}