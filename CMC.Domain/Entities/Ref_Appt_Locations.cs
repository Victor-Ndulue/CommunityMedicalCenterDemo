using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Ref_Appt_Locations
    {
        public Guid LocationCode { get; set; }
        public string? LocationDesciption { get; set; }

        
        public ICollection<Appointments> Appointments { get; set; }
    }
}
