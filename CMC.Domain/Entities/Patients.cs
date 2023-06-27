using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMCDemo.Domain.Entities
{
    public class Patients : CommonAddress
    {
        [Key]
        public int Patient_ID { get; set; }
        [ForeignKey(nameof(Community_Medical_Centers))]
        public int Medical_Center_ID { get; set; }
        [Required, StringLength(15)]
        public string? First_Name { get; set; }
        public string? Middle_Name { get; set; }
        [Required, StringLength(15)]
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        [Required]
        public string? AppointmentWith { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public DateTime Date_Became_Patient { get; }
        public string? Other_Details { get; set; }

        public ICollection<Appointments>? Appointments { get; set; }
    }

}

