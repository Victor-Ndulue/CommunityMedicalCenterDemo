using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s
{
    public class Community_Medical_CentersDto
    {
        public int Id { get; set; }
        [ForeignKey(nameof(MedicalCenterAddress))]
        public int MedicalCenterAddress_Id { get; set; }
        public string? MedicalCenterName;
        public string? MedicalCenterManager { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
