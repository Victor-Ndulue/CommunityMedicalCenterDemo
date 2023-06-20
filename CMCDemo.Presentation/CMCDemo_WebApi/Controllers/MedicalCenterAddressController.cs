using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalCenterAddressController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public MedicalCenterAddressController(IServiceManager serviceManager)
        {
            _serviceManager=serviceManager;
        }

        [HttpPost("medicalcenteraddress/create")]
        public async Task<IActionResult> InsertMedicalCenterAddress(MedicalCenterAddressForCreation creationDto)
        {
            var MedCenterAddress = await _serviceManager.MedicalCenterAddressService.CreateMedicalCenterAddress(creationDto);
            return Ok(MedCenterAddress);
        }

        [HttpGet("medicalcenteraddresses")]
        public async Task<IActionResult> GetAllMedicalCenterAddress()
        {
            var MedicalCenterAddress = await _serviceManager.MedicalCenterAddressService.GetAllMedicalCenterAddress(trackChanges: false);
            return Ok(MedicalCenterAddress);
        }

        [HttpGet("medicalcenteraddress/{id}")]
        public  async Task <IActionResult> GetMedicalCenterAddress( int Id)
        {
            var MedCenterAddress= await _serviceManager.MedicalCenterAddressService.GetMedicalCenterAddressById(Id, trackChanges: false);
            return Ok(MedCenterAddress );
        }

        [HttpPut("medicalcenteraddress/update/{id}")]
        public async Task<IActionResult> UpdateMedicalCenteraddress(int Id, MedicalCenterAddressForUpdate medicalCenterAddressForUpdate)
        {
            var medAddress = await _serviceManager.MedicalCenterAddressService.UpdateMedicalCenterAddress(Id, medicalCenterAddressForUpdate, trackChanges: false);
            return Ok(medAddress);
        }

        [HttpDelete("medicalcenteraddress/delete/{id}")]
        public async Task DeleteMedicalCenterAddress(int Id)
        {
            await _serviceManager.MedicalCenterAddressService.DeleteMedicalCenterAddress(Id, trackChanges: false);
        }
    }
}
