namespace CMCDemo.Domain.Entities
{
    public class StaffAddress: CommonAddress
    {

        public ICollection <ProfessionalStaff>? ProfessionalStaff { get; set; }
    }
}