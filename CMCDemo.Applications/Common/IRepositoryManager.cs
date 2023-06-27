using CMCDemo.Applications.Contracts;

namespace CMCDemo.Applications.Common
{
    public interface IRepositoryManager
    {
        ICommunity_Medical_CentersRepository Community_Medical_Centers { get; }
        IDepartmentRepository Department { get; }
        IMedicalCenterAddress MedicalCenterAddress { get; }
        IProfessionalStaff ProfessionalStaff { get; }
        IRef_Disciplines Ref_Disciplines { get; }
        IStaffAddress StaffAddress { get; }

        Task SaveAsync();
    }
}
