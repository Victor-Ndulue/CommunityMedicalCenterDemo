using CMCDemo.Applications.Common;
using CMCDemo.Applications.Contracts;
using CMCDemo.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy <ICommunity_Medical_CentersRepository> _communityRepository;
        private readonly Lazy <IDepartmentRepository> _departmentRepository;
        private readonly Lazy<IMedicalCenterAddress> _medicalCenterAddress;
        private readonly Lazy<IProfessionalStaff> _professionalStaff;
        private readonly Lazy<IRef_Disciplines> _ref_Disciplines;
        private readonly Lazy<IStaffAddress> _staffAddress;
        private readonly Lazy<IRef_Appt_Locations> _ref_appt_locations;
        private readonly Lazy<IPatientsRepository> _patientsRepository;
        private readonly Lazy<IAppointmentsCategory> _appointmentsCategory;
        private readonly Lazy<IAppointments> _appointments;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _communityRepository= new Lazy<ICommunity_Medical_CentersRepository>(()=> new Community_Medical_CentersRepository(repositoryContext));
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(repositoryContext));
            _medicalCenterAddress = new Lazy<IMedicalCenterAddress>(()=>new MedicalCenterAddressRepository(repositoryContext));
            _professionalStaff = new Lazy<IProfessionalStaff>(() => new ProfessionalStaffRepository(repositoryContext));
            _ref_Disciplines = new Lazy<IRef_Disciplines>(() => new Ref_DisciplinesRepository(repositoryContext));
            _staffAddress = new Lazy<IStaffAddress>(()=>new StaffAddressRepository(repositoryContext));
            _ref_appt_locations = new Lazy<IRef_Appt_Locations>(() => new Ref_Appt_LocationsRepository(repositoryContext));
            _patientsRepository = new Lazy<IPatientsRepository>(()=> new PatientsRepository(repositoryContext));
            _appointmentsCategory = new Lazy<IAppointmentsCategory>(()=> new AppointmentCategoryRepository(repositoryContext));
            _appointments = new Lazy<IAppointments>(()=> new AppointmentsRepository(repositoryContext));
        }
        public ICommunity_Medical_CentersRepository Community_Medical_Centers => _communityRepository.Value;

        public IDepartmentRepository Department => _departmentRepository.Value;

        public IMedicalCenterAddress MedicalCenterAddress => _medicalCenterAddress.Value;

        public IProfessionalStaff ProfessionalStaff => _professionalStaff.Value;

        public IRef_Disciplines Ref_Disciplines => _ref_Disciplines.Value;

        public IStaffAddress StaffAddress => _staffAddress.Value;

        public IRef_Appt_Locations Ref_Appt_Locations => _ref_appt_locations.Value;

        public IPatientsRepository PatientsRepository => _patientsRepository.Value;

        public IAppointmentsCategory AppointmentCategoryRepository => _appointmentsCategory.Value;

        public IAppointments AppointmentsRepository => _appointments.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
