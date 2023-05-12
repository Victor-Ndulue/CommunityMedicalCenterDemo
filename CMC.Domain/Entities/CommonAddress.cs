using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public abstract class CommonAddress: AuditableBaseEntity
    {
        public string? BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Landmark { get; set; }
        public string? Locality { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
