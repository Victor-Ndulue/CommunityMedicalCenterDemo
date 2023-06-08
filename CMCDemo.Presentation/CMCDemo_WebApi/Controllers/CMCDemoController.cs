using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMCDemoController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CMCDemoController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet ("Staff List")]

        public async Task<IActionResult> GetAllProfessionalStaff()
        {
            var ProfessionalStaff = await _serviceManager.ProfessionalStaffService.GetAllProfessionalStaffDtoAsync(trackChanges:false);
            return Ok(ProfessionalStaff);
        }
        [HttpGet ("Community Medical Center List")]
        public async Task<IActionResult> GetAllCommunityMedicalCenter()
        {
            var CommunityMedicalCenter= await _serviceManager.CommunityMedicalCenterService.GetAllCMCDtoAsync(trackChanges:false);
            return Ok(CommunityMedicalCenter);
        }
        [HttpGet ("Medical Center Addresses")]
        public async Task<IActionResult> GetAllMedicalCenterAddress()
        {
            var MedicalCenterAddress = await _serviceManager.MedicalCenterAddressService.GetAllMedicalCenterAddress(trackChanges:false);
            return Ok(MedicalCenterAddress);
        }
        [HttpGet ("List of all staff Addresses")]
        public async Task<IActionResult> GetAllStaffAddress()
        {
            var StaffAddress = await _serviceManager.StaffAddressService.GetAllStaffAddressDtoAsync(trackChanges:false);
            return Ok(StaffAddress);
        }
        [HttpGet ("List of Disciplines")]
        public async Task<IActionResult> GetAllRefDisciplines()
        {
            var RefDiscipline = await _serviceManager.Ref_DisciplinesService.GetAllDisciplinesAsync(trackChanges:false);
            return Ok(RefDiscipline);
        }
        [HttpGet ("List of Departments")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var Department = await _serviceManager.DepartmentService.GetAllDepartmentDto(trackChanges:false);
            return Ok(Department);
        }
    }
}
