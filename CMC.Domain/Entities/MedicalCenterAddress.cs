using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class MedicalCenterAddress : CommonAddress
    {
        public ICollection<Community_Medical_Centers>? MedicalCenters { get; set; }
    }
}
