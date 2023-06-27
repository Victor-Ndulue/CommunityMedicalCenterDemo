
using CMCDemo.Applications.DTO_s.StaffAddressDTOS;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IStaffAddressService
    {
        Task<IEnumerable<StaffAddressDto>> GetAllStaffAddressDtoAsync(bool trackChanges);
        Task<StaffAddressDto> GetStaffAddressDtoAsync(int Id, bool trackChanges);
        Task<StaffAddressDto> CreateStaffAddress(StaffAddressForCreation creationDto);
        Task<StaffAddressDto> UpdateStaffAddress(int Id, StaffAddressForUpdate staffAddressForUpdate, bool trackChanges);
        Task DeleteStaffAddressAsync(int Id, bool trackChanges);
    }
}
