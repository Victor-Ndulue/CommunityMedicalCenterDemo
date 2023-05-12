using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class Patients : AuditableBaseEntity
    {
        public int Patient_ID { get; set; }
        public int Address_ID { get; set; }
        public int Medical_Center_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Gender  { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public DateTime Date_Became_Patient { get;}
        public string? Other_Details { get; set; }

    }

}

