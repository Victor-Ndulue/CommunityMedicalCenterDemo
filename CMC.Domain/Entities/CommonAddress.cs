using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public abstract class CommonAddress: AuditableBaseEntity
    {
        [Required, MaxLength(5)]
        public string? BuildingNumber { get; set; }
        [Required, MaxLength(20)]
        public string? StreetName { get; set; }
        [Required, MaxLength(12)]
        public string? Landmark { get; set; }
        [Required, MaxLength(12)]
        public string? Locality { get; set; }
        [Required, MaxLength(10)]
        public string? City { get; set; }
        [Required, MaxLength(7)]
        public string? PostCode { get; set; }
        [Required, MaxLength(10)]
        public string? State { get; set; }
        [Required, MaxLength(10)]
        public string? Country { get; set; }
    }
}
