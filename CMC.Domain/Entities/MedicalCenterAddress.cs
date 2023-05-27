using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class MedicalCenterAddress : CommonAddress
    {
        [Key] 
        public int Id { get; set; }
        public ICollection<Community_Medical_Centers>? MedicalCenters { get; set; }
    }
}
