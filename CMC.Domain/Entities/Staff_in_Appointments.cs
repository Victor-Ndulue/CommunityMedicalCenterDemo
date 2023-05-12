using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Staff_in_Appointments : Appointments 
    {
        public Guid Appointment_ID { get; set; }
        public Guid Staff_ID { get; set; }

        public virtual ProfessionalStaff? ProfessionalStaff { get; set;}
    }
}
