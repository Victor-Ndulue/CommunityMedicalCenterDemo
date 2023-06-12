using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS
{
    public class Ref_DisciplinesForCreation
    {

        [Required(ErrorMessage ="Discipline name cannot be left vacant")]
        public string? DisciplinesName { get; set; }
        [Required(ErrorMessage = "Discipline description cannot be left vacant")]
        public string? DisciplinesDescription { get; set; }
        [Required(ErrorMessage = "Date obtained discipline cannot be left vacant")]
        public DateTime? DateObtained { get; set; }

        public int ProfessionalStaffId { get; set; }

    }
}