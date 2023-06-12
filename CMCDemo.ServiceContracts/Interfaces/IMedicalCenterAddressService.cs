using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IMedicalCenterAddressService
    {
        Task<IEnumerable<MedicalCenterAddressDto>> GetAllMedicalCenterAddress(bool trackChanges);
        Task<MedicalCenterAddressDto> GetMedicalCenterAddressByName(string Name, bool trackChanges);
        Task<MedicalCenterAddressDto> CreateMedicalCenterAddress(MedicalCenterAddressForCreation creationDto);
        Task<MedicalCenterAddressDto> UpdateMedicalCenterAddress(string Name, MedicalCenterAddressForUpdate Address, bool trackChanges);
        Task DeleteMedicalCenterAddress(string Name, bool trackChanges);
    }
}
