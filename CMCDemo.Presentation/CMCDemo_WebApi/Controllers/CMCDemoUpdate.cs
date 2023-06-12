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
    public class CMCDemoUpdate : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CMCDemoUpdate(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPut("Update Medical Center")]
        public async Task<IActionResult> UpdateMedicalCenter(string Name, Community_Medical_CentersForUpdate community_Medical_CentersForUpdate, bool trackChanges)
        {
             await _serviceManager.CommunityMedicalCenterService.UpdateCMCDto(Name, community_Medical_CentersForUpdate, trackChanges: false);
            return Ok();

        }

        [HttpPut("Update Medical Center Address")]
        public async Task <IActionResult> UpdateMedicalCenteraddress(string Name, MedicalCenterAddressForUpdate medicalCenterAddressForUpdate, bool trackChanges )
        {
             var medAddress = await _serviceManager.MedicalCenterAddressService.UpdateMedicalCenterAddress(Name, medicalCenterAddressForUpdate, trackChanges: false);
            return Ok(medAddress);
        }

        [HttpPut("Update Department details")]
        public async Task<IActionResult> UpdateDepartment(string Name, DepartmentForUpdate departmentForUpdate, bool trackChanges)
        {
            var Department = await _serviceManager.DepartmentService.UpdateDepartment(Name, departmentForUpdate, trackChanges: false);
            return Ok(Department);
        }

        [HttpPut("Update Staff Details")]
        public async Task <IActionResult> UpdateProfessionalStaff(string Name, ProfessionalStaffForUpdate professionalStaffForUpdate, bool trackChanges)
        {
            var Staff = await _serviceManager.ProfessionalStaffService.UpdateProfessionalStaffAsync(Name, professionalStaffForUpdate, trackChanges: false);
            return Ok(Staff);
        }

        [HttpPut("Update Discipline details")]
        public async Task <IActionResult> UpdateDiscipline(string Name, Ref_DisciplinesForUpdate disciplinesForUpdate, bool trackChanges)
        {
            var Discpline = await _serviceManager.Ref_DisciplinesService.UpdateRef_Disciplines(Name, disciplinesForUpdate, trackChanges: false);
            return Ok(Discpline);
        }

        [HttpPut("Update Staff Address")]
        public async Task<IActionResult> UpdateStaffAddress(string Name, StaffAddressForUpdate StaffAddress, bool trackChanges)
        {
            var Address = await _serviceManager.StaffAddressService.UpdateStaffAddress(Name, StaffAddress, trackChanges: false);
            return Ok(Address);
        }
    }
}
