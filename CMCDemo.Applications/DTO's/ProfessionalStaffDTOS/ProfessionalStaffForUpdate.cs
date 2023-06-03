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
    public class ProfessionalStaffForUpdate
    {
        [ForeignKey(nameof(StaffAddress))]
        public int StaffAddress_Id { get; set; }
        [ForeignKey(nameof(Department))]
        public int Department_Id { get; set; }

        public string? PhoneNumber { get; set; }

        public StaffAddress? StaffAddress { get; set; }
        public Department? Department { get; set; }
        public ICollection<Ref_Disciplines>? Ref_Disciplines { get; set; }
    }
}
