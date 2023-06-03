using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s
{
    public class Community_Medical_CentersForUpdate
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Medical Center Name cannot be left vacant")]
        [MaxLength(50, ErrorMessage = "Medical Center Name cannot exceed 50 charaacters")]
        public string? MedicalCenterName;
        [Required(ErrorMessage = "Medical Center Manager Name cannot be left vacant")]
        [MaxLength(20, ErrorMessage = "Medical Center Name cannot exceed 20 charaacters")]
        public string? MedicalCenterManager { get; set; }
        [Required(ErrorMessage = "Phone number must be numbers and cannot be left vacant")]
        [MaxLength(13, ErrorMessage = "Phone number cannot exceed 13 charaacters")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}
