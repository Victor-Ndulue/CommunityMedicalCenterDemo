using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.ServiceContracts.Interfaces;
using CMCDemo.ServiceContracts.IServices;
using CMCDemo.ServiceRepository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceRepository.CommonServices
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProfessionalStaffService> _professionalStaffService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _professionalStaffService = new Lazy<IProfessionalStaffService>(() => new ProfessionalStaffService(repositoryManager, logger, mapper));
        }
       
        public IProfessionalStaffService ProfessionalStaffService => _professionalStaffService.Value;
    }
}
