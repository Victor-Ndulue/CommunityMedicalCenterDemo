using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public StaffController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpPost("staff/create")]
        public async Task<IActionResult> InsertProfessionalStaff(ProfessionalStaffForCreation creationDto)
        {
            var professionalStaffDto = await _serviceManager.ProfessionalStaffService.CreateProfessionalStaffDto(creationDto);
            return Ok(professionalStaffDto);
        }

        [HttpGet("staffs")]

        public async Task<IActionResult> GetAllProfessionalStaff()
        {
            var ProfessionalStaff = await _serviceManager.ProfessionalStaffService.GetAllProfessionalStaffDtoAsync(trackChanges: false);
            return Ok(ProfessionalStaff);
        }

        [HttpGet("staff/{id}")]
        public async Task<IActionResult> GetProfessionalStaff(int Id)
        {
            var Staff = await _serviceManager.ProfessionalStaffService.GetProfessionalStaffDtoAsync(Id, trackChanges: false);
            return Ok(Staff);
        }

        [HttpPut("staff/update/{id}")]
        public async Task<IActionResult> UpdateProfessionalStaff(int Id, ProfessionalStaffForUpdate professionalStaffForUpdate)
        {
            var Staff = await _serviceManager.ProfessionalStaffService.UpdateProfessionalStaffAsync(Id, professionalStaffForUpdate, trackChanges: false);
            return Ok(Staff);
        }

        [HttpDelete("staff/delete/{id}")]
        public async Task DeleteStaff(int Id)
        {
            await _serviceManager.ProfessionalStaffService.DeleteProfessionalStaffAsync(Id, trackChanges: false);
        }
    }
}
