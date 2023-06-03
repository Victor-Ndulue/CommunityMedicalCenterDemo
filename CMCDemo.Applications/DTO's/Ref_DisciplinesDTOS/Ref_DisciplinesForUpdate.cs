using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS
{
    public class Ref_DisciplinesForUpdate
    {
        [DataType(DataType.Date, ErrorMessage = "Date obtained can only be in Date format")]
        public DateTime? DateObtained { get; set; }
    }
}
