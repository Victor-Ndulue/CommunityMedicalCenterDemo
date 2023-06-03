using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.DepartmentDTOS
{
    public class DepartmentForUpdate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name cannot be left vacant")]
        [MaxLength(50, ErrorMessage = "Department Name cannot exceed 50 charaacters")]
        public string? DepartmentName { get; set; }
        [MaxLength(20, ErrorMessage = "Department Chief Name cannot exceed 20 charaacters")]
        public string? DepartmentChief { get; set; }
    }
}
