using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Domain.Entities
{

    public class Staff_in_Appointments : Appointments
    {
        public Guid Appointment_ID { get; set; }
        public Guid Staff_ID { get; set; }
        [Required]
        [StringLength(20)]
        public string? Description { get; set; }

        public ICollection<Appointments>? Patients { get; set; }

        public ProfessionalStaff? ProfessionalStaff { get; set; }


    }
}
