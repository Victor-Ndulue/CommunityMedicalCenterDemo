using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS
{
    public class ProfessionalStaffForCreation
    {
        [ForeignKey(nameof(Community_Medical_Centers))]
        public int MedicalCenter_Id { get; set; }
        [ForeignKey(nameof(StaffAddress))]
        public int StaffAddress_Id { get; set; }
        [ForeignKey(nameof(Department))]
        public int Department_Id { get; set; }

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
        public DateTime DateLeftCenter { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }

    }
}
