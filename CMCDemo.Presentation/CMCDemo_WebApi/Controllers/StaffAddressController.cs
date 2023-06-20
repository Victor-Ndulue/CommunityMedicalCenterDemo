using CMCDemo.Applications.DTO_s.StaffAddressDTOS;
using CMCDemo.ServiceContracts.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMCDemo_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffAddressController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public StaffAddressController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("staffaddress/create")]
        public async Task<IActionResult> InsertStaffAddress(StaffAddressForCreation staffAddressForCreation)
        {
            var StaffAddress = await _serviceManager.StaffAddressService.CreateStaffAddress(staffAddressForCreation);
            return Ok(StaffAddress);
        }

        [HttpGet("staffaddrresses")]
        public async Task<IActionResult> GetAllStaffAddress()
        {
            var StaffAddress = await _serviceManager.StaffAddressService.GetAllStaffAddressDtoAsync(trackChanges: false);
            return Ok(StaffAddress);
        }

        [HttpGet("staffaddress/{id}")]
        public async Task<IActionResult> GetStaffAddress(int Id)
        {
            var StaffAddress = await _serviceManager.StaffAddressService.GetStaffAddressDtoAsync(Id, trackChanges: false);
            return Ok(StaffAddress);
        }

        [HttpPut("staffaddress/update/{id}")]
        public async Task<IActionResult> UpdateStaffAddress(int Id, StaffAddressForUpdate StaffAddress)
        {
            var Address = await _serviceManager.StaffAddressService.UpdateStaffAddress(Id, StaffAddress, trackChanges: false);
            return Ok(Address);
        }

        [HttpDelete("staffaddress/delete/{id}")]
        public async Task DeleteStaffAddress(int Id)
        {
            await _serviceManager.StaffAddressService.DeleteStaffAddressAsync(Id, trackChanges: false);
        }
    }
}
