
using CMCDemo.Applications.DTO_s.StaffAddressDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IStaffAddressService
    {
        Task <IEnumerable<StaffAddressDto>> GetAllStaffAddressDtoAsync (bool trackChanges);
        Task <StaffAddressDto> GetStaffAddressDtoAsync (string Name, bool trackChanges);
        Task<StaffAddressDto> CreateStaffAddress(StaffAddressForCreation creationDto);
        Task<StaffAddressDto> UpdateStaffAddress(string Name, StaffAddressForUpdate staffAddressForUpdate, bool trackChanges);
        Task DeleteStaffAddressAsync (string Name, bool trackChanges);
    }
}
