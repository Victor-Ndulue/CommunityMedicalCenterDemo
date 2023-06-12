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
    public class ProfessionalStaffDto
    {
        public int Id { get; set; }
        public int Community_Medical_CentersId { get; set; }
        public int StaffAddressId { get; set; }
        public int DepartmentId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateBirthed { get; set; }
        public DateTime DateJoinedCenter { get; set; }
        public DateTime DateLeftCenter { get; set; }
        public string? PhoneNumber { get; set; }

        public StaffAddress? StaffAddress { get; set; }
        public Community_Medical_Centers? MedicalCenter { get; set; }
        public Department? Department { get; set; }
        public ICollection<Ref_Disciplines>? Ref_Disciplines { get; set; }
    }
}
