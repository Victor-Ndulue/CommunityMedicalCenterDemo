using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.DTO_s.StaffAddressDTOS
{
    public class StaffAddressDto
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
        public ICollection<ProfessionalStaff>? ProfessionalStaff { get; set; }

    }
}
