using CMCDemo.Applications.DTO_s;
using CMCDemo.Applications.DTO_s.DepartmentDTOS;
using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS;
using CMCDemo.Applications.DTO_s.StaffAddressDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMCDemoCreate : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CMCDemoCreate(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("Create Medical Center")]
        public async Task<IActionResult> InsertMedicalCenter(Community_Medical_CentersForCreation community_Medical_CentersForCreation)
        {
            var MedicalCenter = await _serviceManager.CommunityMedicalCenterService.CreateCMCDto(community_Medical_CentersForCreation);
            return Ok(MedicalCenter);
        }

        [HttpPost("Create Medical Center Address")]
        public async Task<IActionResult> InsertMedicalCenterAddress(MedicalCenterAddressForCreation creationDto)
        {
            var MedCenterAddress = await _serviceManager.MedicalCenterAddressService.CreateMedicalCenterAddress(creationDto);
            return Ok(MedCenterAddress);
        }

        [HttpPost ("Create Department")]
        public async Task <IActionResult> InsertDepartment(DepartmentForCreation creationDto)
        {
            var Department = await _serviceManager.DepartmentService.CreateDepartment(creationDto);
            return Ok(Department);
        }

        [HttpPost(" Create Staff")]
        public async Task<IActionResult> InsertProfessionalStaff(ProfessionalStaffForCreation creationDto)
        {
            var professionalStaffDto = await _serviceManager.ProfessionalStaffService.CreateProfessionalStaffDto(creationDto);
            return Ok(professionalStaffDto);
        }

        [HttpPost("Create Staff Discipline")]
        public async Task<IActionResult> InsertStaffDisciplne(Ref_DisciplinesForCreation creationDto)
        {
            var Discipline = await _serviceManager.Ref_DisciplinesService.CreateRef_Disciplines(creationDto);
            return Ok(Discipline);
        }

        [HttpPost ("Create Staff Address")]
        public async Task<IActionResult> InsertStaffAddress(StaffAddressForCreation staffAddressForCreation)
        {
            var StaffAddress= await _serviceManager.StaffAddressService.CreateStaffAddress(staffAddressForCreation);
            return Ok(StaffAddress);
        }
    }
}
