using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Community_Medical_Centers: AuditableBaseEntity
    {
        [ForeignKey(nameof(MedicalCenterAddress_Id))]
        public int MedicalCenterAddress_Id { get; set; }
        [Required(ErrorMessage ="Medical Center Name cannot be left vacant")]
        [MaxLength(50, ErrorMessage ="Medical Center Name cannot exceed 50 charaacters")]
        public string? MedicalCenterName;
        public string? MedicalCenterManager { get; set; }
        public MedicalCenterAddress? Address { get; set; }
        public UrlAttribute? Url { get; set; }
        [Required(ErrorMessage = "Phone number must be numbers and cannot be left vacant")]
        [MaxLength(13, ErrorMessage = "Phone number cannot exceed 13 charaacters")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "EMail address cannot be left vacant")]
        public EmailAddressAttribute? EmailAddress { get; set; }
        public ICollection<Department>? Departments { get; set; }
        public ICollection<ProfessionalStaff>? Staffs { get; set; }

    }
}
