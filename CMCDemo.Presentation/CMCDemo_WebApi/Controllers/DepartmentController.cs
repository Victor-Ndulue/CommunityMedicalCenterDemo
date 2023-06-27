using CMCDemo.Applications.DTO_s.DepartmentDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DepartmentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpPost("department/create")]
        public async Task<IActionResult> InsertDepartment(DepartmentForCreation creationDto)
        {
            var Department = await _serviceManager.DepartmentService.CreateDepartment(creationDto);
            return Ok(Department);
        }

        [HttpGet("departments")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var Department = await _serviceManager.DepartmentService.GetAllDepartmentDto(trackChanges: false);
            return Ok(Department);
        }

        [HttpGet("department/{id}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var Department = await _serviceManager.DepartmentService.GetDepartmentDto(id, trackChanges: false);
            return Ok(Department);
        }

        [HttpPut("departments/update/{id}")]
        public async Task<IActionResult> UpdateDepartment(int Id, DepartmentForUpdate departmentForUpdate)
        {
            var Department = await _serviceManager.DepartmentService.UpdateDepartment(Id, departmentForUpdate, trackChanges: false);
            return Ok(Department);
        }

        [HttpDelete("department/delete/{id}")]
        public async Task DeleteDepartment(int Id)
        {
            await _serviceManager.DepartmentService.DeleteDepartment(Id, trackChanges: false);
        }
    }
}
