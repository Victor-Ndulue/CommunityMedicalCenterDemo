using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Appointments
    {
        public int Appointments_ID  { get; set; }
        public Guid Location_Code { get; set; }
        public int Patient_ID { get; set; }
        public DateTime Appointment_Date { get; }
        public  string?   Medical_Notes { get;  }
        public string? Other_Details { get;}


    }
}
