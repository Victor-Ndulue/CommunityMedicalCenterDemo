﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public class AppointmentCategory
    {
        [Key]
        public int Appointments_ID { get; set; }
        public Guid Location_Code { get; set; }
        [Required]
        public int Patient_ID { get; set; }
        [Required]
        public DateTime Appointment_Date { get; }
        [Required]
        public string? Medical_Notes { get; }
        [Required]
        public string? Other_Details { get; }

        public ICollection<Appointments>? Appointments { get;}
    }
}
