using CMCDemo.Applications.DTO_s;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityMedicalCenterController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CommunityMedicalCenterController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("communitymedicalcenter/create")]
        public async Task<IActionResult> InsertMedicalCenter(Community_Medical_CentersForCreation community_Medical_CentersForCreation)
        {
            var MedicalCenter = await _serviceManager.CommunityMedicalCenterService.CreateCMCDto(community_Medical_CentersForCreation);
            return Ok(MedicalCenter);
        }

        [HttpGet("communitymedicalcenters")]
        public async Task<IActionResult> GetAllCommunityMedicalCenter()
        {
            var CommunityMedicalCenter = await _serviceManager.CommunityMedicalCenterService.GetAllCMCDtoAsync(trackChanges: false);
            return Ok(CommunityMedicalCenter);
        }

        [HttpGet("communitymedicalcenter/id")]
        public async Task<IActionResult> GetCommunityMedicalCenter(int Id)
        {
            var MedicalCenter = await _serviceManager.CommunityMedicalCenterService.GetCMCDtoAsync(Id, trackChanges: false);
            return Ok(MedicalCenter);
        }

        [HttpPut("communitymedicalcenter/update/id")]
        public async Task<IActionResult> UpdateMedicalCenter(int Id, Community_Medical_CentersForUpdate community_Medical_CentersForUpdate)
        {
            await _serviceManager.CommunityMedicalCenterService.UpdateCMCDto(Id, community_Medical_CentersForUpdate, trackChanges: false);
            return Ok();
        }

        [HttpDelete("communitymedicalcenter/delete/id")]
        public async Task DeleteMedicalCenter(int Id)
        {
            await _serviceManager.CommunityMedicalCenterService.DeleteCMCDto(Id, trackChanges: false);
        }
    }
}
