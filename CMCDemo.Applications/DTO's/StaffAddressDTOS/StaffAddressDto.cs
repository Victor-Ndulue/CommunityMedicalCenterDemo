using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.DTO_s.StaffAddressDTOS
{
    internal class StaffAddressDto
    {
        public int Id { get; set; }
        public string? BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Landmark { get; set; }
        public string? Locality { get; set; }
        public string? City { get; set; }
        public int PostCode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

    }
}
