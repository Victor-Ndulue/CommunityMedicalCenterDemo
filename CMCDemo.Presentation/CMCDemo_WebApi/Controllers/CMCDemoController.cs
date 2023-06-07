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
        [HttpGet]

        public async Task<IActionResult> GetAllProfessionalStaff()
        {
            var ProfessionalStaff = await _serviceManager.ProfessionalStaffService.GetAllProfessionalStaffDtoAsync(trackChanges:false);
            return Ok(ProfessionalStaff);
        }
    }
}
