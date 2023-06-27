using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.ServiceContracts.Interfaces;
using CMCDemo.ServiceContracts.IServices;
using CMCDemo.ServiceRepository.Services;

namespace CMCDemo.ServiceRepository.CommonServices
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProfessionalStaffService> _professionalStaffService;
        private readonly Lazy<ICommunityMedicalCenterService> _communityMedicalCenterService;
        private readonly Lazy<IMedicalCenterAddressService> _medicalCenterAddressService;
        private readonly Lazy<IStaffAddressService> _staffAddressService;
        private readonly Lazy<IRef_DisciplinesService> _refDisciplinesService;
        private readonly Lazy<IDepartmentService> _departmentService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _professionalStaffService = new Lazy<IProfessionalStaffService>(() => new ProfessionalStaffService(repositoryManager, logger, mapper));
            _communityMedicalCenterService = new Lazy<ICommunityMedicalCenterService>(() => new CommunityMedicalCenterServices(repositoryManager, logger, mapper));
            _medicalCenterAddressService = new Lazy<IMedicalCenterAddressService>(() => new MedicalCenterAddressService(repositoryManager, logger, mapper));
            _staffAddressService = new Lazy<IStaffAddressService>(() => new StaffAddressService(repositoryManager, logger, mapper));
            _refDisciplinesService = new Lazy<IRef_DisciplinesService>(() => new Ref_DisciplinesService(repositoryManager, logger, mapper));
            _departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(repositoryManager, logger, mapper));
        }

        public IProfessionalStaffService ProfessionalStaffService => _professionalStaffService.Value;
        public ICommunityMedicalCenterService CommunityMedicalCenterService => _communityMedicalCenterService.Value;
        public IMedicalCenterAddressService MedicalCenterAddressService => _medicalCenterAddressService.Value;
        public IStaffAddressService StaffAddressService => _staffAddressService.Value;
        public IRef_DisciplinesService Ref_DisciplinesService => _refDisciplinesService.Value;
        public IDepartmentService DepartmentService => _departmentService.Value;
    }
}
