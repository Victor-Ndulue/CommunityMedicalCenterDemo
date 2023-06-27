using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IMedicalCenterAddressService
    {
        Task<IEnumerable<MedicalCenterAddressDto>> GetAllMedicalCenterAddress(bool trackChanges);
        Task<MedicalCenterAddressDto> GetMedicalCenterAddressById(int Id, bool trackChanges);
        Task<MedicalCenterAddressDto> CreateMedicalCenterAddress(MedicalCenterAddressForCreation creationDto);
        Task<MedicalCenterAddressDto> UpdateMedicalCenterAddress(int Id, MedicalCenterAddressForUpdate Address, bool trackChanges);
        Task DeleteMedicalCenterAddress(int Id, bool trackChanges);
    }
}
