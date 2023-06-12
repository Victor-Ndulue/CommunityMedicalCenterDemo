using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.DepartmentDTOS
{
    public class DepartmentForCreation
    {
        [Required(ErrorMessage ="Department name is required")]
        [MaxLength(20, ErrorMessage = "Department Name cannot exceed 20 charaacters")]
        public string? DepartmentName { get; set; }
        [MaxLength(20, ErrorMessage = "Department Chief name cannot exceed 20 charaacters")]
        public string? DepartmentChief { get; set; }
        [Required]
        public int Community_Medical_CentersId { get; set; }
    }
}
