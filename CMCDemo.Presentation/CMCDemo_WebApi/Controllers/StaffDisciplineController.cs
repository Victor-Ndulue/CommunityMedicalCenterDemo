using CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffDisciplineController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public StaffDisciplineController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpPost("staffdiscipline/create")]
        public async Task<IActionResult> InsertStaffDisciplne(Ref_DisciplinesForCreation creationDto)
        {
            var Discipline = await _serviceManager.Ref_DisciplinesService.CreateRef_Disciplines(creationDto);
            return Ok(Discipline);
        }

        [HttpGet("staffdisciplines")]
        public async Task<IActionResult> GetAllRefDisciplines()
        {
            var RefDiscipline = await _serviceManager.Ref_DisciplinesService.GetAllDisciplinesAsync(trackChanges: false);
            return Ok(RefDiscipline);
        }

        [HttpPut("staffdiscipline/update/{id}")]
        public async Task<IActionResult> UpdateDiscipline(int Id, Ref_DisciplinesForUpdate disciplinesForUpdate)
        {
            var Discpline = await _serviceManager.Ref_DisciplinesService.UpdateRef_Disciplines(Id, disciplinesForUpdate, trackChanges: false);
            return Ok(Discpline);
        }

        [HttpDelete("staffdiscipline/delete/{id}")]
        public async Task DeleteDiscipline(int Id)
        {
            await _serviceManager.Ref_DisciplinesService.DeleteRef_DisciplinesAsync(Id, trackChanges: false);
        }
    }
}
