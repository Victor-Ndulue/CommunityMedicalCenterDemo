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
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string? DepartmentName { get; set; }
        public string? DepartmentChief { get; set; }
    }
}
