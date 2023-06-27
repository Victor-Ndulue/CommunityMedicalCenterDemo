using CMCDemo.ServiceContracts.Interfaces;

namespace CMCDemo.ServiceContracts.IServices
{
    public interface IServiceManager
    {
        IProfessionalStaffService ProfessionalStaffService { get; }
        public ICommunityMedicalCenterService CommunityMedicalCenterService { get; }
        public IMedicalCenterAddressService MedicalCenterAddressService { get; }
        public IStaffAddressService StaffAddressService { get; }
        public IRef_DisciplinesService Ref_DisciplinesService { get; }
        public IDepartmentService DepartmentService { get; }
    }
}
