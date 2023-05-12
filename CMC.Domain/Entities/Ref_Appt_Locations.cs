using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Ref_Appt_Locations
    {
        public Guid Location_Code { get; set; }
        public string? Location_Description { get; set; }

        public Ref_Appt_Locations()
        {
            
        }

    }
}
