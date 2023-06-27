﻿using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS
{
    public class Ref_DisciplinesForUpdate
    {
        public string? DisciplinesName { get; set; }
        [Required(ErrorMessage = "Discipline description cannot be left vacant")]
        public string? DisciplinesDescription { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Date obtained can only be in Date format")]
        public DateTime? DateObtained { get; set; }
    }
}
