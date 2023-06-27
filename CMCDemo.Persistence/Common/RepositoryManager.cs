using CMCDemo.Applications.Common;
using CMCDemo.Applications.Contracts;
using CMCDemo.Persistence.Repository;

namespace CMCDemo.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICommunity_Medical_CentersRepository> _communityRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;
        private readonly Lazy<IMedicalCenterAddress> _medicalCenterAddress;
        private readonly Lazy<IProfessionalStaff> _professionalStaff;
        private readonly Lazy<IRef_Disciplines> _ref_Disciplines;
        private readonly Lazy<IStaffAddress> _staffAddress;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _communityRepository = new Lazy<ICommunity_Medical_CentersRepository>(() => new Community_Medical_CentersRepository(repositoryContext));
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(repositoryContext));
            _medicalCenterAddress = new Lazy<IMedicalCenterAddress>(() => new MedicalCenterAddressRepository(repositoryContext));
            _professionalStaff = new Lazy<IProfessionalStaff>(() => new ProfessionalStaffRepository(repositoryContext));
            _ref_Disciplines = new Lazy<IRef_Disciplines>(() => new Ref_DisciplinesRepository(repositoryContext));
            _staffAddress = new Lazy<IStaffAddress>(() => new StaffAddressRepository(repositoryContext));
        }
        public ICommunity_Medical_CentersRepository Community_Medical_Centers => _communityRepository.Value;

        public IDepartmentRepository Department => _departmentRepository.Value;

        public IMedicalCenterAddress MedicalCenterAddress => _medicalCenterAddress.Value;

        public IProfessionalStaff ProfessionalStaff => _professionalStaff.Value;

        public IRef_Disciplines Ref_Disciplines => _ref_Disciplines.Value;

        public IStaffAddress StaffAddress => _staffAddress.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
