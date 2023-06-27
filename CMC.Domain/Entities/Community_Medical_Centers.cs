using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMCDemo.Domain.Entities
{
    public class Community_Medical_Centers
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Medical Center Name cannot be left vacant")]
        [MaxLength(50, ErrorMessage = "Medical Center Name cannot exceed 50 charaacters")]
        public string? MedicalCenterName { get; set; }
        [Required(ErrorMessage = "Medical Center Manager Name cannot be left vacant")]
        [MaxLength(20, ErrorMessage = "Medical Center Name cannot exceed 20 charaacters")]
        public string? MedicalCenterManager { get; set; }
        [Required(ErrorMessage = "Phone number must be numbers and cannot be left vacant")]
        [MaxLength(13, ErrorMessage = "Phone number cannot exceed 13 charaacters")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }


        [ForeignKey(nameof(MedicalCenterAddress))]
        public int MedicalCenterAddressId { get; set; }
        public MedicalCenterAddress? MedicalCenterAddress { get; set; }

        public virtual ICollection<Department>? Departments { get; set; }
        public virtual ICollection<ProfessionalStaff>? Staffs { get; set; }

    }
}
