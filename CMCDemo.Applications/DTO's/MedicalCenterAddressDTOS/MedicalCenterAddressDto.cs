using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS
{
    public class MedicalCenterAddressDto
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
        public ICollection<Community_Medical_Centers>? Community_Medical_Centers { get; set; }
    }
}
