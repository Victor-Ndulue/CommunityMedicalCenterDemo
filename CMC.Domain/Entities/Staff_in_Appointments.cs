using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{

    public class Staff_in_Appointments  
    {
        [Key] 
        public int Id { get; set; }
        
        [ForeignKey(nameof(Appointments))] 
        
        public Guid Appointment_ID { get; set; }
       
        [ForeignKey(nameof(ProfessionalStaff))]
        public int Staff_ID { get; set; }
        [Required]
        [StringLength(20)]
        public string? Description { get; set; }    

        public Appointments? Appointment { get; set; }

        public  ProfessionalStaff? ProfessionalStaff { get; set;}
        
         
    }
}
