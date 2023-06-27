using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Applications.DTO_s
{
    public class Community_Medical_CentersForCreation
    {
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
        public int MedicalCenterAddressId;
        public MedicalCenterAddressForCreation? MedicalCenterAddress { get; set; }
    }
}
