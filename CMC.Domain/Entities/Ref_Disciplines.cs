﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMCDemo.Domain.Entities
{
    public class Ref_Disciplines
    {
        [Key]
        public int Ref_DisciplinesId { get; set; }

        [Required]
        public string? DisciplinesName { get; set; }
        [Required]
        public string? DisciplinesDescription { get; set; }
        [Required]
        public DateTime? DateObtained { get; set; }

        [ForeignKey(nameof(ProfessionalStaff))]
        public int ProfessionalStaffId { get; set; }
        public virtual ProfessionalStaff? ProfessionalStaff { get; set;}
    }
}