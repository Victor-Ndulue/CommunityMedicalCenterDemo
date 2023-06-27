using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Domain.Entities
{
    public class Appointments
    {
        [Key]
        public int Id { get; set; }
        public ICollection<AppointmentCategory>? AppointmentCategory { get; set; }
    }
}
